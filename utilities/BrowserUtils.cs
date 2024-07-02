using System.Threading;

namespace csharp_cucumber_selenium_framework.utilities
{
    public static class BrowserUtils
    {
        /*
         * This method will accept int (in seconds) and execute Thread.Sleep for a given duration
         */
        public static void Sleep(int seconds)
        {
            seconds *= 1000; // convert seconds to milliseconds
            try
            {
                Thread.Sleep(seconds);
            }
            catch (ThreadInterruptedException)
            {
                // Handle interrupted exception if needed
            }
        }

        public static string GenerateTurkishPhoneNumber()
        {
                var faker = new Bogus.Faker("tr"); // Using Turkish locale
                string prefix = "5" + faker.Random.Number(30, 59).ToString(); // Prefixes between 530 and 559
                string middle = faker.Random.Number(100, 999).ToString("D3"); // 3-digit middle part
                string last = faker.Random.Number(1000, 9999).ToString("D4"); // 4-digit last part

                return $"{prefix}{middle}{last}";
        }
        
    }
}