using System;
using System.Linq;
using System.Windows.Forms;
using AkcjeLib;

namespace VehicleServiceApp
{
    public partial class Form1 : Form
    {
        private ServiceManager serviceManager;
        private BindingSource vehicleBindingSource;

        public Form1()
        {
            InitializeComponent();
            serviceManager = new ServiceManager();
            vehicleBindingSource = new BindingSource();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VehicleListBox.DataSource = vehicleBindingSource;
            VehicleListBox.DisplayMember = "DisplayInfo";

            Vehicle vehicle1 = new Vehicle
            {
                RegistrationNumber = "XYZ123",
                Brand = "Toyota",
                Model = "Corolla",
                Year = 2015,
                Mileage = 100000
            };

            Vehicle vehicle2 = new Vehicle
            {
                RegistrationNumber = "ABC987",
                Brand = "Ford",
                Model = "Focus",
                Year = 2018,
                Mileage = 75000
            };


            ServiceTask serviceTask1 = new ServiceTask
            {
                TaskName = "Wymiana oleju",
                MileageAtService = 15000,
                DateOfService = new DateTime(2016, 3, 15)
            };

            ServiceTask serviceTask2 = new ServiceTask
            {
                TaskName = "Wymiana filtra powietrza",
                MileageAtService = 30000,
                DateOfService = new DateTime(2017, 7, 10)
            };

            ServiceTask serviceTask3 = new ServiceTask
            {
                TaskName = "Kontrola hamulców",
                MileageAtService = 15000,
                DateOfService = new DateTime(2019, 5, 20)
            };

            ServiceTask serviceTask4 = new ServiceTask
            {
                TaskName = "Wymiana rozrz¹du",
                MileageAtService = 60000,
                DateOfService = new DateTime(2023, 1, 15)
            };

            // Dodawanie wpisów do historii serwisowej pojazdów
            vehicle1.ServiceHistory.Add(serviceTask1);
            vehicle1.ServiceHistory.Add(serviceTask2);

            vehicle2.ServiceHistory.Add(serviceTask3);
            vehicle2.ServiceHistory.Add(serviceTask4);

            // Dodawanie pojazdów do Ÿród³a danych
            vehicleBindingSource.Add(vehicle1);
            vehicleBindingSource.Add(vehicle2);

            // Odœwie¿enie widoku
            vehicleBindingSource.ResetBindings(false);


        }

        private void AddVehicleButton_Click(object sender, EventArgs e)
        {

            foreach (Vehicle vehicle in vehicleBindingSource.List)
            {
                if (vehicle.RegistrationNumber == RegistrationNumberTextBox.Text)
                {
                    MessageBox.Show("Pojazd z takim numerem rejestracyjnym ju¿ istnieje!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Dodanie nowego pojazdu na podstawie danych z pól tekstowych
            Vehicle newVehicle = new Vehicle
            {
                RegistrationNumber = RegistrationNumberTextBox.Text,
                Brand = BrandTextBox.Text,
                Model = ModelTextBox.Text,
                Year = int.Parse(YearTextBox.Text),
                Mileage = int.Parse(MileageTextBox.Text)
            };

            vehicleBindingSource.Add(newVehicle);
            vehicleBindingSource.ResetBindings(false);
            MessageBox.Show("Nowy pojazd zosta³ dodany.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CheckServiceButton_Click(object sender, EventArgs e)
        {
            if (VehicleListBox.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano pojazdu!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedVehicle = (Vehicle)VehicleListBox.SelectedItem;
            var tasks = serviceManager.GetServiceTasks(selectedVehicle.Mileage);

            ServiceTasksListBox.Items.Clear();
            foreach (var task in tasks)
            {
                ServiceTasksListBox.Items.Add(task);
            }
        }

        private void AddServiceButton_Click(object sender, EventArgs e)
        {
            if (VehicleListBox.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano pojazdu!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (ServiceTasksListBox.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano czynnoœci serwisowej!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedVehicle = (Vehicle)VehicleListBox.SelectedItem;
            var selectedTask = ServiceTasksListBox.SelectedItem.ToString();

            if (!int.TryParse(MileageServTextBox.Text, out int mileage))
            {
                MessageBox.Show("Proszê podaæ prawid³owy przebieg.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var serviceTask = new ServiceTask
                {
                    TaskName = selectedTask,
                    MileageAtService = mileage,
                    DateOfService = DateTime.Now
                };

                serviceManager.AddService(selectedVehicle, serviceTask);
                selectedVehicle.Mileage = int.Parse(MileageServTextBox.Text);
                vehicleBindingSource.ResetBindings(false);
                MessageBox.Show("Czynnoœæ serwisowa zosta³a dodana.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (DuplicateServiceException ex)
            {
                MessageBox.Show(ex.Message, "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ShowHistoryButton_Click(null, EventArgs.Empty);
        }

        private void ShowHistoryButton_Click(object sender, EventArgs e)
        {
            if (VehicleListBox.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano pojazdu!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedVehicle = (Vehicle)VehicleListBox.SelectedItem;
            HistoryListBox.Items.Clear();

            foreach (var task in selectedVehicle.ServiceHistory)
            {
                HistoryListBox.Items.Add(task);
            }



            RegistrationNumberTextBox.Text = selectedVehicle.RegistrationNumber;
            BrandTextBox.Text = selectedVehicle.Brand;
            ModelTextBox.Text = selectedVehicle.Model;
            YearTextBox.Text = selectedVehicle.Year.ToString();
            MileageTextBox.Text = selectedVehicle.Mileage.ToString();
            MileageServTextBox.Text = selectedVehicle.Mileage.ToString();
            CheckServiceButton_Click(null, EventArgs.Empty);
        }

        private void SortByMileageButton_Click(object sender, EventArgs e)
        {
            var sortedVehicles = vehicleBindingSource.List
                .Cast<Vehicle>()
                .OrderByDescending(v => v.Mileage)
                .ToList();

            VehicleListBox.DataSource = null;
            VehicleListBox.DataSource = sortedVehicles;
            VehicleListBox.DisplayMember = "DisplayInfo";
        }

        private void SortByBrandButton_Click(object sender, EventArgs e)
        {
            var sortedVehicles = vehicleBindingSource.List
                .Cast<Vehicle>()
                .OrderBy(v => v.Brand)
                .ToList();

            VehicleListBox.DataSource = null; // Od³¹czenie starego Ÿród³a
            VehicleListBox.DataSource = sortedVehicles; // Ustawienie nowego Ÿród³a danych
            VehicleListBox.DisplayMember = "DisplayInfo";
        }

        private void EditVehicleButton_Click_Click(object sender, EventArgs e)
        {

            if (VehicleListBox.SelectedItem == null)
            {
                MessageBox.Show("Nie wybrano pojazdu do edycji!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            Vehicle selectedVehicle = (Vehicle)VehicleListBox.SelectedItem;


            foreach (Vehicle vehicle in vehicleBindingSource.List)
            {
                if (vehicle.RegistrationNumber == RegistrationNumberTextBox.Text && vehicle != selectedVehicle)
                {
                    MessageBox.Show("Numer rejestracyjny musi byæ unikalny!", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            // Aktualizacja danych pojazdu
            selectedVehicle.RegistrationNumber = RegistrationNumberTextBox.Text;
            selectedVehicle.Brand = BrandTextBox.Text;
            selectedVehicle.Model = ModelTextBox.Text;
            selectedVehicle.Year = int.Parse(YearTextBox.Text);
            selectedVehicle.Mileage = int.Parse(MileageTextBox.Text);

            // Odœwie¿enie listy
            vehicleBindingSource.ResetBindings(false);
            MessageBox.Show("Dane pojazdu zosta³y zaktualizowane.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SearchVehicleButton_Click_Click(object sender, EventArgs e)
        {

            string searchQuery = RegistrationSearchTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchQuery))
            {
                MessageBox.Show("Proszê wpisaæ numer rejestracyjny.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
           
            Vehicle foundVehicle = vehicleBindingSource.List.OfType<Vehicle>().FirstOrDefault(v => v.RegistrationNumber.Equals(searchQuery, StringComparison.OrdinalIgnoreCase));

            if (foundVehicle != null)
            {
                VehicleListBox.SelectedItem = foundVehicle; // Ustawienie wybranego pojazdu
            }
            else
            {
                MessageBox.Show("Nie znaleziono pojazdu o podanym numerze rejestracyjnym.", "Wynik", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void label8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programowanie Zaawansowane AD 2024");
        }

        private void SortByMileageButton_Click_1(object sender, EventArgs e)
        {
            var sortedVehicles = vehicleBindingSource.List
                .Cast<Vehicle>()
                .OrderBy(v => v.Brand)
                .ToList();

            VehicleListBox.DataSource = null; // Od³¹czenie starego Ÿród³a
            VehicleListBox.DataSource = sortedVehicles; // Ustawienie nowego Ÿród³a danych
            VehicleListBox.DisplayMember = "DisplayInfo";
        }
    }
}
