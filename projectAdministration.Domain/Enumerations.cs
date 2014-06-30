using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace projectAdministration.Domain
{

        public enum UserStatus
        {
            notStartedToWork = 0,
            active = 1,
            vaction,
            medicalLeave,
            dismissal
            //add some state if required
        }

        public enum SkillLevel
        {
            entrant = 0,
            novice=1,
            medior,
            senior,
            expert
            //add some state if required
        }


        public enum ProjectType
        {
            TimeAndMaterials =0,
            FixedPrice = 1,
            ProofOfConcept,
            Other
        }

        public enum ReviewType
        {
            Informal=0,
            Formal = 1,
            StatusCheck,
            TechnicalReview,
            Inprovment,
            Issue
        }

        public enum QuestionType
        {
            FreeText=0,
            Radio=1,
            CheckBox,
            Rating
        }

    }
