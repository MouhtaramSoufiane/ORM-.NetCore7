using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Mywebapp.Model
{
    [Table("Students")]
    public class Student
    {
        [Key]
        public int StudentId{get;set;}
        public string Prenom{get;set;}=string.Empty;
        public string Nom{get;set;}=string.Empty;
        public float Note{get;set;}
    }
}