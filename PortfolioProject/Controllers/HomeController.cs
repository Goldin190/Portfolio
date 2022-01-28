using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;

namespace PortfolioProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Encoding encoding = Encoding.UTF8;
            string message = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Suspendisse egestas, lectus id condimentum ornare, justo nulla commodo sapien, nec facilisis arcu quam at dui. Mauris vitae eros et dui scelerisque vestibulum. Aliquam elementum risus sed urna ullamcorper, quis lobortis odio rhoncus. Sed pulvinar turpis tempor, pellentesque nulla at, pharetra dolor. Sed luctus mauris ac nibh pulvinar vehicula. Nunc vel nibh molestie, mattis mi at, placerat nunc. Vestibulum malesuada arcu a erat accumsan, sit amet malesuada massa commodo. Mauris porta ornare mauris ac efficitur. Vivamus suscipit consectetur nulla nec hendrerit. Fusce at ex quis erat dignissim pellentesque vitae sit amet est. Mauris finibus dui vitae velit commodo sollicitudin. Vivamus vehicula lorem porta est efficitur auctor. Nunc accumsan, metus non blandit tincidunt, elit nisl accumsan massa, id posuere enim turpis quis justo. Sed ac nisi vitae ligula hendrerit hendrerit."+
                "Proin lacinia auctor dictum. Vivamus sed accumsan neque. Proin vel urna ac metus vestibulum ultrices non et ante. Sed ante turpis, suscipit a arcu et, dignissim aliquet neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Aenean vel blandit lacus, dictum mollis metus. Cras interdum ex vel nunc eleifend, non blandit risus semper.Sed nec dignissim neque. Nulla facilisi. Nam luctus diam pellentesque nisl pretium vehicula in sit amet sem." +
                "Fusce lorem velit, ornare vel nibh non, pretium condimentum velit. Nulla facilisi. Morbi rutrum, metus in consectetur rutrum, arcu massa fringilla magna, at rhoncus arcu ipsum a quam. Proin interdum erat eu dolor cursus consequat.Morbi tempus sagittis efficitur. Pellentesque suscipit elementum mi, hendrerit commodo dui aliquet a. Fusce sit amet ex erat.Maecenas eu ipsum libero. Nulla ultrices quis nibh eleifend ultricies." +
                "Vestibulum ut pellentesque massa. Donec pulvinar tempor nunc, et fringilla erat eleifend id. Suspendisse mollis sapien ultrices dolor hendrerit pharetra.Vestibulum lacus velit, dictum quis lacus eget, eleifend imperdiet tellus. Maecenas luctus purus eu rutrum vehicula. Sed mattis consectetur finibus. Quisque vehicula nunc nec justo mollis sodales.Suspendisse libero enim, tristique ut mauris sit amet, pharetra cursus neque.Nullam maximus mattis ligula. Sed commodo, metus sed bibendum sodales, nibh sapien gravida nunc, et porttitor felis nisl non ante.Fusce iaculis magna mauris, sit amet commodo justo porttitor nec.Sed malesuada dignissim nibh quis pellentesque." +
                "Integer vel tortor faucibus erat fermentum iaculis.Ut interdum rhoncus accumsan. Duis efficitur euismod imperdiet. Cras iaculis elit lectus, at tempus dolor tincidunt sed. Aliquam tincidunt nisi sit amet dolor sodales, in tempor felis rhoncus.Donec dolor leo, rhoncus tempor posuere at, volutpat et eros. Morbi consectetur erat nunc, at semper diam posuere eu." +
                "Donec auctor sagittis auctor. Fusce semper mauris arcu, nec maximus velit malesuada sit amet.Phasellus in ante non massa eleifend tempus id vitae nunc. Etiam in iaculis urna, nec dictum lorem. Praesent rutrum libero eu urna auctor maximus.Sed sed nunc bibendum, accumsan tortor vel, blandit quam.Sed interdum leo quis varius molestie. Suspendisse vel odio sit amet eros tempus sollicitudin." +
                "Suspendisse ut arcu nisl. Donec eget risus eu arcu elementum elementum.Fusce dui justo, fermentum eget mattis et, bibendum vel erat. Nunc tortor turpis, sagittis at nisl quis, maximus fringilla nisi. Phasellus eget risus odio. Proin mi turpis, fringilla et aliquam at, lobortis at tortor. In tempus ipsum eget pellentesque ultricies. Maecenas eu odio metus." +
                "Fusce feugiat erat non erat hendrerit convallis.Etiam ullamcorper sollicitudin metus, mollis luctus elit facilisis et. Fusce elit ipsum, consequat ut mauris vel, tempus molestie sem. Proin maximus sem a odio tincidunt, ut sagittis lorem luctus.Quisque vehicula posuere sapien non porta. Phasellus auctor quis urna non vestibulum. Curabitur nec eleifend elit, quis mattis sapien. Cras auctor, felis a tincidunt gravida, diam tellus sagittis odio, ut iaculis massa eros sed turpis.Aenean non ipsum orci. Nulla cursus ante in feugiat interdum. Suspendisse commodo nisl at ipsum molestie, consequat interdum lorem tristique.Curabitur tincidunt, nisl quis lacinia elementum, turpis mauris eleifend ex, ut mollis ipsum dolor at metus.Proin non luctus massa. Donec pretium ornare rhoncus. In semper sem at magna condimentum, et tempor metus sagittis.Mauris laoreet, ligula sit amet euismod fringilla, lorem mi vestibulum sapien, quis fringilla turpis ex at erat." +
                "Fusce lobortis euismod vulputate. Nullam nulla justo, tempus et nibh varius, mollis blandit ante. Morbi et nulla viverra, auctor mauris eget, blandit sem.Morbi in tellus convallis, molestie erat at, fermentum urna.Donec consequat et dolor vel ullamcorper. Proin ac eros varius, euismod sapien eget, luctus diam.Phasellus porttitor cursus mollis. Aenean semper quam risus, sed tincidunt sem congue vitae. Nulla facilisi. Pellentesque rhoncus vehicula enim, id malesuada odio ultrices a. Phasellus convallis mi eros, vitae gravida ipsum euismod nec. Mauris mauris dolor, egestas eget enim et, faucibus tincidunt justo. Donec lobortis diam vehicula nisi porta imperdiet.Donec sit amet tempor risus.Mauris ultricies sit amet ex eu blandit.Nulla fermentum finibus enim pharetra mattis." +
                "Morbi leo elit, fermentum vitae massa in, ornare lobortis justo.Vestibulum ante ipsum primis in faucibus orci luctus et ultrices posuere cubilia curae; Pellentesque dapibus ullamcorper nibh vehicula accumsan. Ut hendrerit, leo sed cursus consectetur, risus velit laoreet massa, vel interdum nisl massa et ligula.Morbi vitae erat eu felis pharetra semper a ut neque. Lorem ipsum dolor sit amet, consectetur adipiscing elit.Donec vitae dolor non nunc fringilla rhoncus.Cras aliquet, enim ut consequat cursus, lacus quam mattis quam, a laoreet risus lacus eget urna.In suscipit pharetra urna in pretium.Praesent quis tincidunt nulla, eget pretium leo. Pellentesque dapibus vehicula arcu, non faucibus ipsum maximus vel. Etiam efficitur volutpat auctor. Integer erat quam, rhoncus vel hendrerit nec, dictum non ex. Nam laoreet felis et velit sodales, sed interdum velit consectetur.";
            byte[] bytes = encoding.GetBytes(DateTime.Now.ToString()+" "+message);
            ViewBag.Binary = string.Join(" ", bytes.Select(byt => Convert.ToString(byt, 2).PadLeft(8, '0'))); ;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}