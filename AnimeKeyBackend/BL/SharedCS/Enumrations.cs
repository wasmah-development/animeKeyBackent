using System.Collections.Generic;

namespace BL.SharedCS
{
    public static class Enumrations
    {
        
        public enum EN_AlertType { OverSpeed = 1, LowBattery, LowFuel, GeoFence, Sos, OverWeight }

        public enum EN_TaskStatus { New = 1, NeedApproval, Approved, InProccess,Finished,Canceled }

        public enum EN_Modules { UsersManagement=1,SystemSettings ,TasksManagement,CustomersManagement}

        public enum EN_Screens { Groups = 1,Users ,LookUps,JobTitle,Nationality,TaskType,Items,Employees, Country ,Departments,WorkShifts,Customers,Tasks,FixedAssetsType,FixedAsset,FixedAssetRequest, MonitorEmployees, CompanyBranches, Vendors, ContractType ,
            ModelMakerVehicle,ServiceType , Vehicle, VehiclesStatus, Contracts , Services , Purchasers , ContractorTypes , OdometerMeasures, Costs,
            VehicleFuel, OdometerVehicle, DisplayGroup, VehicleDisplayGroup,Regions,
            Drivers, VehicleDrivers, Vehicles, SysKeyVal,VehicleRegion,Languages,Cameras,Category, Company, Maintenance, DriverDecument, Alerts,Pages,PagesTypes
        }

        public enum EN_Permissions { View = 1, Create,Edit,Delete }

        public enum EN_LookUps { Gender = 1, EducationDegrees, TaskPeriorities,CustomerTypes,TargetTypes }
        public enum EN_AssetStatus { InProccess = 1, Canceled, Finished }

        public enum CostAmount
        {
            no =1 ,
            daily=2 ,
            weekly=3,
            monthly=4 ,
            yearly=5
        }

        public enum ContractStatus
        {
            New = 1,
            InProgress,
            Expired,
            Closed
        }

        public enum TransmissionType
        {
            Manual = 1,
            Automatic
        }

        public enum FuelType
        {
            GasOline = 1,
            Electric,
            Diesel
        }


        public enum ReprotStartStopType
        {
            stop = 1,
            start = 2
        }

        public enum TypeOfAlert
        {
            Overspeed = 1,
            Lowbattery = 2,
            Lowfuel = 3,
            Geofencealert = 4,
            Sosalert = 5,
            overWeight=6,
            robbery=7
        }

        
      

        public enum VehicleTypes
        {
            Car = 1,
            MotorCycle = 2,
            Taxi = 3,
            Truck = 4,
            Tools = 5,
            Trailer = 6
        }
        public enum EN_Languages { ar = 1, en, id }
        public enum EN_FlipFlop { movingOn = 1,stopOn,stopOff,idelCar }
    }
}
