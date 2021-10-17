using System;
using System.Collections.Generic;
using System.Text;

namespace PDC60.Models
{//Di pa lahat to nung parameters.
    public class Tree
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string TreeCode { get; set; }
        public string Identification { get; set; }
        public string Notes { get; set; }
        public string Landmark { get; set; }
        public string TrunkFlare { get; set; }
        public double Height { get; set; }
        public double DMB { get; set; }
        public string SurfaceRoots { get; set; }
        public string Canopy { get; set; }
    }
}
