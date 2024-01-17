using EDriveRent.Core.Contracts;
using EDriveRent.Models;
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories;
using EDriveRent.Repositories.Contracts;
using EDriveRent.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Core
{
    public class Controller : IController
    {
        private IRepository<IUser> users;
        private IRepository<IVehicle> vehicles;
        private IRepository<IRoute> routes;
        private string[] vehicleTypes = { "PassengerCar", "CargoVan" };
        public Controller()
        {
            users = new UserRepository();
            vehicles = new VehicleRepository();
            routes = new RouteRepository();
        }
        public string AllowRoute(string startPoint, string endPoint, double length)
        {
            if (routes.GetAll().Any(r => r.StartPoint == startPoint && r.EndPoint == endPoint && r.Length == length))
            {
                return string.Format(OutputMessages.RouteExisting, startPoint, endPoint, length);
            }
            if (routes.GetAll().Any(r => r.StartPoint == startPoint && r.EndPoint == endPoint && r.Length < length))
            {
                return string.Format(OutputMessages.RouteIsTooLong, startPoint, endPoint);
            }
            IRoute route = null;
            if (routes.GetAll().Any(r => r.StartPoint == startPoint && r.EndPoint == endPoint && r.Length > length))
            {
                route = routes.GetAll().FirstOrDefault(r => r.StartPoint == startPoint && r.EndPoint == endPoint && r.Length > length);
                route.LockRoute();
            }
            route = new Route(startPoint, endPoint, length, routes.GetAll().Count + 1);
            routes.AddModel(route);

            return string.Format(OutputMessages.NewRouteAdded, startPoint, endPoint, length);


        }

        public string MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
        {
            IUser user = users.FindById(drivingLicenseNumber);
            IVehicle vehicle = vehicles.FindById(licensePlateNumber);
            IRoute route = routes.FindById(routeId);
            if(user.IsBlocked == true)
            {
                return string.Format(OutputMessages.UserBlocked, drivingLicenseNumber);
            }

            if (vehicle.IsDamaged == true)
            {
                return string.Format(OutputMessages.VehicleDamaged, licensePlateNumber);
            }

            if (route.IsLocked == true)
            {
                return string.Format(OutputMessages.RouteLocked, routeId);
            }

            vehicle.Drive(route.Length);

            if (isAccidentHappened)
            {
                vehicle.ChangeStatus();
                user.DecreaseRating();
            }
            else
            {
                user.IncreaseRating();
            }

            if (vehicle.IsDamaged == true)
            {
                return $"{vehicle.Brand} {vehicle.Model} License plate: {vehicle.LicensePlateNumber} Battery: {vehicle.BatteryLevel}% Status: damaged";
            }
            else
            {
                return $"{vehicle.Brand} {vehicle.Model} License plate: {vehicle.LicensePlateNumber} Battery: {vehicle.BatteryLevel}% Status: OK";
            }


        }

        public string RegisterUser(string firstName, string lastName, string drivingLicenseNumber)
        {
            IUser user = users.FindById(drivingLicenseNumber);
            if (user != null)
            {
                return string.Format(OutputMessages.UserWithSameLicenseAlreadyAdded, drivingLicenseNumber);
            }
            user = new User(firstName, lastName, drivingLicenseNumber);
            users.AddModel(user);
            return string.Format(OutputMessages.UserSuccessfullyAdded, firstName, lastName, drivingLicenseNumber);
        }

        public string RepairVehicles(int count)
        {
            int repairedVehicleCount = 0;
            foreach (var vehicle 
                in vehicles
                .GetAll()
                .Where(v => v.IsDamaged == true)
                .OrderBy(v => v.Brand)
                .ThenBy(v => v.Model)
                .Take(count))
            {
                vehicle.ChangeStatus();
                vehicle.Recharge();
                repairedVehicleCount++;
            }

            return $"{repairedVehicleCount} vehicles are successfully repaired!";
        }

        public string UploadVehicle(string vehicleType, string brand, string model, string licensePlateNumber)
        {
            if (!vehicleTypes.Contains(vehicleType))
            {
                return string.Format(OutputMessages.VehicleTypeNotAccessible, vehicleType);
            }

            IVehicle vehicle = vehicles.FindById(licensePlateNumber);
            if (vehicle != null)
            {
                return string.Format(OutputMessages.LicensePlateExists, licensePlateNumber);
            }

            if(vehicleType == "PassengerCar")
            {
                vehicle = new PassengerCar(brand, model, licensePlateNumber);
            }
            else if (vehicleType == "CargoVan")
            {
                vehicle = new CargoVan(brand, model, licensePlateNumber);
            }
            vehicles.AddModel(vehicle);
            return string.Format(OutputMessages.VehicleAddedSuccessfully, brand, model, licensePlateNumber);
        }

        public string UsersReport()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*** E-Drive-Rent ***");
            foreach (var user 
                in users
                .GetAll()
                .OrderByDescending(u => u.Rating)
                .ThenBy(u => u.LastName)
                .ThenBy(u => u.FirstName))
            {
                sb.AppendLine(user.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
