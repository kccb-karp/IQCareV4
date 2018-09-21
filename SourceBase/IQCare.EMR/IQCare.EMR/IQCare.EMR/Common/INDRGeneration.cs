﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Interface.EMR
{
    public interface INDRGeneration
    {
        DataSet GetPatientDetails(int facilityID);
        void SavePatientDetails(int patientId);
    }
}
