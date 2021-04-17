using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin;

namespace ATOM.Models
{
    // В профиль пользователя можно добавить дополнительные данные, если указать больше свойств для класса ApplicationUser. Подробности см. на странице https://go.microsoft.com/fwlink/?LinkID=317594.
    public class ApplicationUser : IdentityUser
    {

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Обратите внимание, что authenticationType должен совпадать с типом, определенным в CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Здесь добавьте утверждения пользователя
            return userIdentity;
        }
    }


    /// <summary>
    /// Стажёр
    /// </summary>
    public class Improver
    {
        [Key]
        public int ID { get; set; }
        public int VUZ_ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactPhone { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public bool Verified { get; set; }
    }


    /// <summary>
    /// Работодатель
    /// </summary>
    public class Employer      
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ContactPhone { get; set; }
        public string OrganizationName { get; set; }
        public string OrganizationINN { get; set; }
        public bool Verified { get; set; }
    }


    public class Vladyka
    {
        [Key]
        public int ID { get; set; }
        public string Email { get; set; }
        public string ContactPhone { get; set; }
        public string Password { get; set; }
    }



    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false) { }

        public DbSet<Improver> Improver { get; set; }
        public DbSet<Employer> Employers { get; set; }
        public DbSet<Vladyka> Vladyki { get; set; }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }

    public class AppDbInitializer : CreateDatabaseIfNotExists<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext context)
        {
            var userManager = new AppManager(new UserStore<ApplicationUser>(context));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));

            // создаем две роли
            IdentityRole role1 = new IdentityRole { Name = "admin" },
                         role2 = new IdentityRole { Name = "employer" },
                         role3 = new IdentityRole { Name = "Improver" };

            // добавляем роли в бд
            roleManager.Create(role1);
            roleManager.Create(role2);
            roleManager.Create(role3);

            // создаем пользователей
            ApplicationUser admin = new ApplicationUser { UserName = "admin_001" };
            string password = "Q1w2e3r4";
            var result = userManager.Create(admin, password);

            // если создание пользователя прошло успешно
            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(admin.Id, role1.Name);
                context.UserInfo.Add(new User
                {
                    UserName = admin.UserName,
                    Password = password.toMD5(),
                    Roles = new string[1] { role1.Name }
                });
            }

            base.Seed(context);
            //context.SaveChanges();
        }
    }

    public class AppManager : UserManager<ApplicationUser>
    {
        public AppManager(IUserStore<ApplicationUser> store) : base(store)
        {
        }

        public static AppManager Create(IdentityFactoryOptions<AppManager> options,
                                           IOwinContext context)
        {
            ApplicationDbContext db = context.Get<ApplicationDbContext>();
            AppManager manager = new AppManager(new UserStore<ApplicationUser>(db));
            return manager;
        }
    }


    
}