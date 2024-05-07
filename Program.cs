using portfolioProject.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddSingleton<IAdminRepository, MockAdminRepository>();
builder.Services.AddScoped<IAboutMeRepository, MockAboutMeRepository>();
builder.Services.AddScoped<IEducationRepository, MockEducationRepository>();
builder.Services.AddScoped<IExperienceRepository, MockExperienceRepository>();
builder.Services.AddScoped<IHobbiesRepository, MockHobbiesRepository>();
builder.Services.AddScoped<IReferenceRepository, MockReferenceRepository>();
builder.Services.AddScoped<ISkillsRepository, MockSkillsRepository>(); 
builder.Services.AddScoped<IWorkflowRepository, MockWorkflowRepository>(); 



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
