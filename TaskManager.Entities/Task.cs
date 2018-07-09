﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace TaskManager.Entities
{
    public class Task
    {
        [Key()]                
        public int TaskID
        {
            get;
            set;
        }

        
        [ForeignKey("ParentTask")]
        public int ParentTaskID
        {
            get;
            set;
        }

        [Required(ErrorMessage ="Task Desc Required")]
        public string TaskDesc
        {
            get;
            set;
        }

        [Required(ErrorMessage ="StartDate Required")]
        [DataType(DataType.DateTime,ErrorMessage ="Invalid DateTime")]
        public DateTime StartDate
        {
            get;
            set;
        }
        [Required(ErrorMessage ="EndDate Required")]
        [DataType(DataType.DateTime,ErrorMessage ="Invalid DateTime")]
        public DateTime EndDate
        {
            get;
            set;
        }
        [Required(ErrorMessage ="Priority Required")]
        [Range(0,30,ErrorMessage ="Invalid Range")]
        public int Priority
        {
            get;
            set;
        }

        public bool TaskStatus
        {
            get;
            set;
        }

        public virtual ParentTask ParentTask { get; set; }
    }
}
