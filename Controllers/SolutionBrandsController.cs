using Microsoft.AspNetCore.Mvc;
using System.Reflection;
using WeeBtpWebsite.Models;
using WeeBtpWebsite.Services;

namespace WeeBtpWebsite.Controllers
{
    public class SolutionBrandsController : Controller
    {
        private BrevoMailService _mailService;
        public SolutionBrandsController()
        {
            _mailService = new BrevoMailService();
        }
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult BTPCodeIGNITE()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BTPCodeIGNITE(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult BTPSecuriSCOPE()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BTPSecuriSCOPE(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult BTPCloudEXCELON()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BTPCloudEXCELON(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult BTPConnect()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BTPConnect(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult BTPManageSP()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BTPManageSP(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult BTPDatastAIsis()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BTPDatastAIsis(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }
        public ActionResult BTPTechAdvisors()
        {
            return View();
        }
        [HttpPost]
        public ActionResult BTPTechAdvisors(ContactUsModel model)
        {
            string Name = model.firstName;
            string Email = model.email;
            string PhoneNumber = model.phoneNumber;
            string Subject = model.Subject;
            string Message = model.Message;
            _mailService.SendEmail(Name, Email, Subject, PhoneNumber, Message);
            return View("ThanksPage");
        }

    }
}
