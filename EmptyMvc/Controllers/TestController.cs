using EmptyMvc.Services;
using Microsoft.AspNetCore.Mvc;

namespace EmptyMvc.Controllers
{
    public class TestController : Controller
    {
        private readonly ISingletonService singeltonService;
        private readonly IScopedService scopedService;
        private readonly IScopedService scopedService2;
        private readonly ITransientService transientService;
        private readonly ITransientService transientService2;

        public TestController(
            ISingletonService singeltonService,
            IScopedService scopedService,
            IScopedService scopedService2,
            ITransientService transientService,
            ITransientService transientService2
            )
        {
            this.singeltonService = singeltonService;
            this.scopedService = scopedService;
            this.scopedService2 = scopedService2;
            this.transientService = transientService;
            this.transientService2 = transientService2;
        }

        public IActionResult List()
        {
            var output = 
                $" singeltonService : {singeltonService.GetId()} <br /><br />" +

                $" scopedService : {scopedService.GetId()} <br />" +
                $" scopedService2 : {scopedService2.GetId()} <br /><br />" +

                $" transientService : {transientService.GetId()} <br />" +
                $" transientService2 : {transientService2.GetId()} <br />";
            
            return View("List", output);
        }
    }
}
