using System;
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
        public ApplicationDbContext() : base("IdentityConnection", throwIfV1Schema: false) { }

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
            ApplicationUser admin = new ApplicationUser { UserName = "admin_001@admin.ru", Email = "admin_001@admin.ru" };
            ApplicationUser Improver_001 = new ApplicationUser { UserName = "Improver_001@Improver.ru", Email = "Improver_001@Improver.ru" };
            ApplicationUser Improver_002 = new ApplicationUser { UserName = "Improver_002@Improver.ru", Email = "Improver_002@Improver.ru" };
            ApplicationUser Improver_003 = new ApplicationUser { UserName = "Improver_003@Improver.ru", Email = "Improver_003@Improver.ru" };
            ApplicationUser Improver_004 = new ApplicationUser { UserName = "Improver_004@Improver.ru", Email = "Improver_004@Improver.ru" };
            ApplicationUser Improver_005 = new ApplicationUser { UserName = "Improver_005@Improver.ru", Email = "Improver_005@Improver.ru" };
            ApplicationUser Employer_001 = new ApplicationUser { UserName = "Employer_001@Employer.ru", Email = "Employer_001@Employer.ru" };
            ApplicationUser Employer_002 = new ApplicationUser { UserName = "Employer_002@Employer.ru", Email = "Employer_002@Employer.ru" };
            ApplicationUser Employer_003 = new ApplicationUser { UserName = "Employer_003@Employer.ru", Email = "Employer_003@Employer.ru" };
            ApplicationUser Employer_004 = new ApplicationUser { UserName = "Employer_004@Employer.ru", Email = "Employer_004@Employer.ru" };
            ApplicationUser Employer_005 = new ApplicationUser { UserName = "Employer_005@Employer.ru", Email = "Employer_005@Employer.ru" };
            string password = "Q1w2e3r4";
            var result = userManager.Create(admin, password);

            // если создание пользователя прошло успешно
            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(admin.Id, role1.Name);
                context.Vladyki.Add(new Vladyka
                {
                    Email = admin.UserName,
                    Password = password
                });
            }

            result = userManager.Create(Improver_001, password);

            // если создание пользователя прошло успешно
            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(Improver_001.Id, role3.Name);
                context.Improver.Add(new Improver
                {
                    Email = Improver_001.UserName,
                    Password = password, 
                    ContactPhone = "+131400000000",
                    FirstName = "Билл",
                    LastName = "Гейтс",
                    MiddleName = "Майкрософтович",
                    Verified = true
                });
            }

            result = userManager.Create(Improver_002, password);

            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(Improver_002.Id, role3.Name);
                context.Improver.Add(new Improver
                {
                    Email = Improver_002.UserName,
                    Password = password,
                    ContactPhone = "+31415926535897",
                    FirstName = "Архимед",
                    LastName = "Критский",
                    MiddleName = "Геометриевич",
                    Verified = true
                });
            }

            result = userManager.Create(Improver_003, password);

            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(Improver_003.Id, role3.Name);
                context.Improver.Add(new Improver
                {
                    Email = Improver_003.UserName,
                    Password = password,
                    ContactPhone = "+27182818284",
                    FirstName = "Леонард",
                    LastName = "Эйлер",
                    MiddleName = "Матанович",
                    Verified = true
                });
            }

            result = userManager.Create(Improver_004, password);

            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(Improver_004.Id, role3.Name);
                context.Improver.Add(new Improver
                {
                    Email = Improver_004.UserName,
                    Password = password,
                    ContactPhone = "+0112358132134",
                    FirstName = "Леонардо",
                    LastName = "Пизанский",
                    MiddleName = "Фибоначчивич",
                    Verified = true
                });
            }

            result = userManager.Create(Improver_005, password);

            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(Improver_005.Id, role3.Name);
                context.Improver.Add(new Improver
                {
                    Email = Improver_005.UserName,
                    Password = password,
                    ContactPhone = "+662607004081",
                    FirstName = "Макс",
                    LastName = "Планк",
                    MiddleName = "Квантович",
                    Verified = true
                });
            }

            result = userManager.Create(Employer_001, password);

            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(Employer_001.Id, role2.Name);
                context.Employers.Add(new Employer
                {
                    Email = Employer_001.UserName,
                    Password = password,
                    ContactPhone = "+000000000",
                    OrganizationName = "Warhammer",
                    OrganizationINN = "40000",
                    Verified = true
                });
            }

            result = userManager.Create(Employer_002, password);

            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(Employer_002.Id, role2.Name);
                context.Employers.Add(new Employer
                {
                    Email = Employer_002.UserName,
                    Password = password,
                    ContactPhone = "+111111111",
                    OrganizationName = "Aperture Laboratories",
                    OrganizationINN = "111111111",
                    Verified = true
                });
            }

            result = userManager.Create(Employer_003, password);

            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(Employer_003.Id, role2.Name);
                context.Employers.Add(new Employer
                {
                    Email = Employer_003.UserName,
                    Password = password,
                    ContactPhone = "+222222222",
                    OrganizationName = "Umbrella",
                    OrganizationINN = "222222222",
                    Verified = true
                });
            }

            result = userManager.Create(Employer_004, password);

            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(Employer_004.Id, role2.Name);
                context.Employers.Add(new Employer
                {
                    Email = Employer_004.UserName,
                    Password = password,
                    ContactPhone = "+333333333",
                    OrganizationName = "Abstergo Industries",
                    OrganizationINN = "333333333",
                    Verified = true
                });
            }

            result = userManager.Create(Employer_005, password);

            if (result.Succeeded)
            {
                // добавляем для пользователя роль
                userManager.AddToRole(Employer_005.Id, role2.Name);
                context.Employers.Add(new Employer
                {
                    Email = Employer_005.UserName,
                    Password = password,
                    ContactPhone = "+555555555",
                    OrganizationName = "Stark Industries",
                    OrganizationINN = "555555555",
                    Verified = true
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