using HelloWorldWebapp.Models;

namespace HelloWorldWebapp.Services
{
    public static class CarService
    {
        public static List<Car> Cars { get; }
        static CarService()
        {
            Cars = new List<Car>
            {
                new Car { Name="Zoom" },
                new Car { Name="Crash"}
            };
        }

        public static void Add(Car car)
        {
            Cars.Add(car);
        }

        public static List<Car> GetAll()
        {
            return Cars;
        }
    }
}
