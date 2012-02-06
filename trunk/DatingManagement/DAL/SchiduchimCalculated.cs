﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DatingManagement.DAL
{
    public partial class Family
    {

        public string Name
        {
            get
            {
                return (this.LastName == null ? "" : this.LastName) + " ," + (this.FatherName == null ? "" : this.FatherName);
            }
        }
    }

    public partial class Boy
    {

        public string Name
        {
            get
            {
                if (this.Family == null) return string.Empty;
                return (this.Family.LastName == null ? "" : this.Family.LastName) + " ," + (this.Family.FatherName == null ? "" : this.Family.FatherName);
            }
        }

        public string MotherName
        {
            get
            {
                if (this.Family == null) return string.Empty;
                return (this.Family.MotherName == null ? "" : this.Family.MotherName);
            }
        }

        public string Region
        {
            get
            {
                if (this.Family == null) return string.Empty;
                return (this.Family.Region == null ? "" : this.Family.Region);
            }
        }

        public string HomePhone
        {
            get
            {
                if (this.Family == null) return string.Empty;
                return (this.Family.HomePhone1 == null ? "" : this.Family.HomePhone1);
            }
        }

    }

    public partial class Girl
    {

        public string Name
        {
            get
            {
                if (this.Family == null) return string.Empty;
                return (this.Family.LastName == null ? "" : this.Family.LastName) + " ," + (this.Family.FatherName == null ? "" : this.Family.FatherName);
            }
        }

        public string MotherName
        {
            get
            {
                if (this.Family == null) return string.Empty;
                return (this.Family.MotherName == null ? "" : this.Family.MotherName);
            }
        }

        public string Region
        {
            get
            {
                if (this.Family == null) return string.Empty;
                return (this.Family.Region == null ? "" : this.Family.Region);
            }
        }

        public string HomePhone
        {
            get
            {
                if (this.Family == null) return string.Empty;
                return (this.Family.HomePhone1 == null ? "" : this.Family.HomePhone1);
            }
        }

    }
 
    public partial class MadeShiduchim
    {
        public string MonthName
        {
            get
            {
                if (this.Month == null)
                    return string.Empty;


                {
                    var q = DataLayer.Dataclass.Months.Where(M => M.ID == this.Month);
                    if (q.Count() > 0)
                        return q.First().Month1;
                    else
                        return string.Empty;
                }

            }
        }

        public string BoySideName
        {
            get
            {
                if (this.BoysSide == null)
                    return string.Empty;


                {
                    var q = DataLayer.Dataclass.Families.Where(M => M.FathersID == this.BoysSide);
                    if (q.Count() > 0)
                        return q.First().Name;
                    else
                        return string.Empty;
                }

            }
        }

        public string GirlSideName
        {
            get
            {
                if (this.GirlsSide == null)
                    return string.Empty;


                {
                    var q = DataLayer.Dataclass.Families.Where(M => M.FathersID == this.GirlsSide);
                    if (q.Count() > 0)
                        return q.First().Name;
                    else
                        return string.Empty;
                }

            }
        }
    }

     
}
