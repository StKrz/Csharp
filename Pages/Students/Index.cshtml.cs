using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
using WebStarterDBApp1.DTO;
using WebStarterDBApp1.Models;
using WebStarterDBApp1.Services;

namespace WebStarterDBApp1.Pages.Students
{
    public class IndexModel : PageModel
    {
        public List<StudentReadOnlyDTO>? Students { get; set; } = new();
        public Error? ErrorObj { get; set; } = new();

        private readonly IMapper? _mapper;
        private readonly IStudentService? _studentService;

        public IndexModel(IMapper? mapper, IStudentService? studentService)
        {
            _mapper = mapper;
            _studentService = studentService;
        }

        public IActionResult OnGet()
        {
            try
            {
                ErrorObj = null;
                IList<Student> students = _studentService!.GetAllStudents();

                foreach (var student in students)
                {
                    StudentReadOnlyDTO? studentDTO = _mapper!.Map<StudentReadOnlyDTO>(student);
                    Students!.Add(studentDTO);
                }
            }
            catch (Exception e)
            {
                ErrorObj = new Error("", e.Message, "");
            }

            return Page();
        }
    }
}