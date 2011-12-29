using System;
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
}
