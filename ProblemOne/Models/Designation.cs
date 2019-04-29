using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ProblemOne.Models
{
    public enum Designation
    {
        [Description("Software Engineer Level 1")]
        SoftwareEngineerLevel1,
        [Description("Software Engineer Level 2")]
        SoftwareEngineerLevel2,
        [Description("Software Engineer Level 3")]
        SoftwareEngineerLevel3,
        [Description("Testing Engineer")]
        TestingEngineer,
        [Description("Product Manager")]
        ProductManager
    }
}
