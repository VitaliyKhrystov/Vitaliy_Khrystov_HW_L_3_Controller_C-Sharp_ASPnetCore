namespace Task_4
{
    public class Program
    {
        //������� 3
        //������������� ���������� SampleApp �� ��������� ������� � ������� ����� �����
        //�������, ����� ���������� ����� �� ������ �� ������� �������� ����������� �
        //������� ���������� ������ ��������, ������� ���������� ����.

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