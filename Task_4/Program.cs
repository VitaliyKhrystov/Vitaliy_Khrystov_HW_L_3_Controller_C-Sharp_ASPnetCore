namespace Task_4
{
    public class Program
    {
        //Задание 3
        //Модифицируйте приложение SampleApp из домашнего задания к первому уроку таким
        //образом, чтобы скачивание файла по ссылке на главной странице происходило с
        //помощью выполнения метода действия, который возвращает файл.

        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }
        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}