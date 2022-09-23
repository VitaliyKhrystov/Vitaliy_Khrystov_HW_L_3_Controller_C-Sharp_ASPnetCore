using System.Xml.Linq;

namespace Task_1
{
    public class Program
    {

        //������� 1 (Additional Task)
        //�������� ��� ����������.�������� ������, ������� ����� ������������ ��������� ��������
        //�� ���������� Id, Price, Name.��������� ��������� ���������� ����������.
        //�������� ���������� Products � ������� ������� Index, ������� ���������� ������������� ��
        //����� ������� �� ������. �������� �������� ������ � ������������� ����� ���������, �����
        //ViewBag � ����� ������ �������������� �������������.� ������ ����������� �� �����������
        //�� ����� ���������� ������������� ����� ������� ���������?



        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}