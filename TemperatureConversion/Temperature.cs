    class Temperature
    {
    // Public field for Kelvin
        public double Kelvin { get; set; }

    // Property to calculate Celsius from Kelvin
        public double Celsius
        {
            get
            {
                return Kelvin - 273.15;
            }
        }

    // Property to calculate Fahrenheit from Celsius
        public double Fahrenheit
        {
            get
            {
                return Celsius * 9 / 5 + 32;
            }
        }

    // Constructor for Temperature (optional)
        public Temperature(double kelvin = 0)
        {
            Kelvin = kelvin < 0 ? 0 : kelvin;  // Ensure Kelvin is never less than 0
        }
    }