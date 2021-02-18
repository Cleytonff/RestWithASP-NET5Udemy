﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASP_NET5Udemy.Model
{
    [Table("books")]
    public class Book
    {
        [Column("id")]
        public long Id { get; set; }
        [Column("author")]
        public string Author { get; set; }
        [Column("launch_date")]
        public DateTime LaunchDate { get; set; }
        [Column("price")]
        public float Price { get; set; }
        [Column("title")]
        public string Title { get; set; }

        /*
 * `id` INT(10) AUTO_INCREMENT PRIMARY KEY,
`author` longtext,
`launch_date` datetime(6) NOT NULL,
`price` decimal(65,2) NOT NULL,
`title` longtext
*/
    }
}
