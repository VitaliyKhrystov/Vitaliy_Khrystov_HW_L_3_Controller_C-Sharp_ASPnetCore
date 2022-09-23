using System.Xml.Linq;

namespace Task_1
{
    public class Program
    {

        //Задание 1 (Additional Task)
        //Создайте веб приложение.Добавьте модель, которая будет представлять коллекцию объектов
        //со свойствами Id, Price, Name.Заполните коллекцию случайными значениями.
        //Сделайте контроллер Products с методом доступа Index, который возвращает представление со
        //всеми данными из модели. Сделайте передачу данных в представление двумя способами, через
        //ViewBag и через строго типизированное представление.С какими сложностями Вы столкнулись
        //во время реализации представлений двумя разными способами?



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