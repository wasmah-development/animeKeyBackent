using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class Languages : BaseEntity
    {

        [Key]
        public long Id { get; set; }

        public long UserId { get; set; }


        public bool ArabicEnglish { get; set; }

        public bool EnglishIndonesiah { get; set; }
    }
}
