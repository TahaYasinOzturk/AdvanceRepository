using AdvanceRepository.UnitOfWork;
using Microsoft.AspNetCore.Mvc;

namespace AdvanceRepository.Controllers
{
    public class BaseController : Controller
    {
        public IUnitOfWork UnitOfWork;

        //neden unitofwork deilde ınuitofworkden ulasıyoruz.?  cünkü interfaceden almak  prompra.cs de ıuow uow a baglı depencey injection demek uow classini baska yerde kullanabillrsin demek basına iuow dersek depencey injection oluyor baglı yapıyoruz. cunku uow de yeni bisi yaptık test edicez. uow2 diye bisi method yazdık onu orda unitofworkde yeni uow2 diye bisi olusturduk. builder.Services.AddScoped<IUnitOfWork , UnitOfWork2>(); diye degistirsek  heryerde degistirmek yerine sadece appscpooed de yeni ismi ıuow ın yanına yazınca hepsini görecek  . gerçi base controller yaparak isimizi kolaylastırmıstık ama diger product ve categoriesde bunu yapmak cok isimize yarar.
        //builder.Services.AddScoped<CategoriesModel>(); bu  injection oluyor. normali.
        //builder.Services.AddScoped<IUnitOfWork , UnitOfWork>(); böyle olursa depencey injection of inversion  oluyor adı. ınterface baglı ise adı degisiyor.

        // ctrl nokta yapıp field ekledik. 
        public BaseController(IUnitOfWork UnitOfWork)
        {
            this.UnitOfWork = UnitOfWork;
        }
    }
}
