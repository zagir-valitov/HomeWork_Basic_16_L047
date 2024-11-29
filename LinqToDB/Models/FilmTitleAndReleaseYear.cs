using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperToDB.Models
{
    [Table("film")]
    public class FilmTitleAndReleaseYear
    {
        [Column("title")]
        public string Title { get; set; }


        [Column("release_year")]
        public int Release_Year { get; set; }
    }
}
