namespace Task_2
{
    public class Program
    {

        //Задание 2
        //Создайте веб приложение с пользовательским интерфейсом, представляющим простой
        //калькулятор.Приложение должно иметь два поля ввода для числовых значений и несколько
        //кнопок для арифметических действий. Реализуйте контроллер, который будет обрабатывать
        //запросы и выполнять арифметические действия.


        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

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