var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

//www��̬�ļ��м��

//DefaultFilesOptions options=new DefaultFilesOptions();
//options.DefaultFileNames.Clear();
//options.DefaultFileNames.Add("MyHtml.html");

//app.UseDefaultFiles(options);  //Ĭ��ȥ��WWW��default��index
//app.UseStaticFiles();  //���з���www��Դ��Ȩ��


//www��̬�ļ��м������2
FileServerOptions options=new FileServerOptions();
options.DefaultFilesOptions.DefaultFileNames.Clear();
options.DefaultFilesOptions.DefaultFileNames.Add("MyHtml.html");
app.UseFileServer(options);


app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
