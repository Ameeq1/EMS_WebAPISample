using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EMS_WebAPISample.EmergencyModel
{
    public class PostEventAnalysisDetails
    {
        public PostEventAnalysis postEventAnalysis { get; set; }
        public EmergencyPostEventAnalysisFollowUp emergencyPostEventAnalysisFollowUp { get; set; }
        public string ActionTakenByStaff { get; set; }
        public string Observation { get; set; }
        public List<QuickResponseTeam> quickResponseTeams { get; set; }
        public BasicLifeSupport basicLifeSupport { get; set; }
        public UploadAttachments uploadAttachments { get; set; }
        public CAPA cAPA { get; set; }
        public string PostEventVerificationComment { get; set; }
        public ActionItem actionItem { get; set; }
        public string ActionVerificationComment { get; set; }
    }
    public class PostEventAnalysis
    {
        public int TypeOfArrestId { get; set; }  // enum
        public string TypeOfArrestDescription { get; set; }
        public int TypeOfRythmId { get; set; }  //enum
        public decimal IsBLSInitiated { get; set; }
        public decimal IsDefibrillatorAttached { get; set; }
        public decimal IsACLS { get; set; }
        public decimal IsConsciousnessRegained { get; set; }
        public decimal IsFamilyCounseled { get; set; }
        public DateTime PatientLastAccessed { get; set; }
        public decimal Temperature { get; set; }
        public decimal Pulse { get; set; }
        public decimal R { get; set; }
        public decimal BPSystolic { get; set; }
        public decimal BPDiastolic { get; set; }
        public decimal SPO2 { get; set; }
        public decimal HGT { get; set; }
        public decimal GCS { get; set; }
    }

    public class EmergencyPostEventAnalysisFollowUp
    {
        public decimal IsROCSAchieved { get; set; }
        public string ROCSTransferredTo { get; set; }
        public DateTime ROCSTransferredTime { get; set; }  // Time
        public decimal IsTTM { get; set; }
        public decimal IsCS48Hrs { get; set; }
        public string TransferOutTo { get; set; }
        public DateTime TransferOn { get; set; }
        public string DischargedToHome { get; set; }
        public decimal IsExpired { get; set; }

    }


    public class QuickResponseTeam
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string Designation { get; set; }
    }

    public class BasicLifeSupport
    {

    }

    public class UploadAttachments
    {

    }

    public class CAPA
    {

    }

    public class ActionItem
    {

    }
}

