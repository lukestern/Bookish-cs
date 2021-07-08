using Bookish_cs.EntityClasses;
using System.Collections.Generic;
using System.Linq;

namespace Bookish_cs.Models
{
    public class PersonManagementViewModel
    {
        public List<PersonViewModel> People { get; set; }

        public PersonManagementViewModel(List<PersonDbModel> people)
        {
            People = people.Select(person => new PersonViewModel(person)).ToList();
        }
    }
}