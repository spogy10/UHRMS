using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using UHRMS.Models;

namespace UHRMS.Utility
{
    public class CriteriaCalculation
    {
        private int ParishPoints {get; set;}
        private int ChildrenPoints {get; set;}
        private int ParentPoints {get; set;}
        private int FinancingPoints {get; set;}
        private int OtherFinancialNeedsPoints { get; set; }
        private int ExtraCurricularActivityPoints {get; set;}
        private int SpecialSkillsPoints {get; set;}
        

        private int GeographicalLocationPoints {get; set;}
        private int FinancialNeedsPoints {get; set;}
        private int InvolvementPoints {get; set;}
        private int SpecialNeedsPoints {get; set;}
        private int CompletionOfFormPoints {get; set;}

        private int Total => CalculatePoints();


        private BoardingApplicationForm _form;
        private BoardingApplicationForm Form
        {
            get => _form;
            
            set
            {
                _form = value;
            }
        }

        public CriteriaCalculation(BoardingApplicationForm form)
        {
            this.Form = form;
        }

        public int CalculatePoints()
        {
            CalculateGeographicalLocationPoints();
            CalculateFinancialNeedsPoints();
            CalculateInvolvementPoints();
            CalculateSpecialNeedsPoints();
            CalculateCompletionOfFormPoints();

            return GeographicalLocationPoints + FinancialNeedsPoints + InvolvementPoints + SpecialNeedsPoints +
                    CompletionOfFormPoints;
        }

        private void CalculateGeographicalLocationPoints()
        {
            CalculateParishPoints();

            GeographicalLocationPoints = ParishPoints;
        }

        private void CalculateParishPoints()
        {
            switch(Form.parish)
            {
               case "Kingston & St. Andrew": ParishPoints = 2;
                   break;

               case "Clarendon": ParishPoints = 6;
                   break;

               case "Hanover": ParishPoints = 8;
                   break;

               case "Manchester": ParishPoints = 7;
                   break;

               case "Portland": ParishPoints = 6;
                   break;

               case "St. Ann": ParishPoints = 7;
                   break;

               case "St. Catherine": ParishPoints = 2;
                   break;

               case "St. Elizabeth": ParishPoints = 8;
                   break;

               case "St. James": ParishPoints = 8;
                   break;
               case "St Mary": ParishPoints = 6;
                   break;
               case "St. Thomas": ParishPoints = 6;
                   break;

               case "Trelawny": ParishPoints = 8;
                   break;

                case "Westmoreland": ParishPoints = 8;
                    break;
                default: ParishPoints = 0;
                    break;
            }

    }

        private void CalculateFinancialNeedsPoints()
        {
            CalculateChildrenPoints();
            CalculateParentPoints();
            CalculateFinancingPoints();
            CalculateOtherFinancialNeedsPoints();

            FinancialNeedsPoints = ChildrenPoints + ParentPoints + FinancingPoints + OtherFinancialNeedsPoints;
        }

        private void CalculateOtherFinancialNeedsPoints()
        {
            //todo: find a way to calculate this
            OtherFinancialNeedsPoints = 0;
        }

        private void CalculateFinancingPoints()
        {
            if (Form.slbQuestion || Form.requestedSponsorship || Form.requestedGrant)
            {
                FinancingPoints = 10;
            }
            else if (Form.areYouFinancing)
            {
                FinancingPoints = 5;
            }
            else
            {
                FinancingPoints = 0;
            }
        }

        private void CalculateParentPoints()
        {
            //todo: find a way to calculate this
            ParishPoints = 0;
        }

        private void CalculateChildrenPoints()
        {
            var children = Form.numberOfDependants;

            if (children >= 5)
            {
                ChildrenPoints = 4;
            }
            else if (children == 4)
            {
                ChildrenPoints = 3;
            }
            else if (children == 3)
            {
                ChildrenPoints = 2;
            }
            else if (children == 2)
            {
                ChildrenPoints = 1;
            }
            else if (children == 1)
            {
                ChildrenPoints = 0;
            }
            else
            {
                ChildrenPoints = 0;
            }
        }

        private void CalculateInvolvementPoints()
        {
            CalculateExtraCurricularActivityPoints();
            CalculateSpecialSkillsPoints();

            InvolvementPoints = ExtraCurricularActivityPoints + SpecialSkillsPoints;
        }

        private void CalculateSpecialSkillsPoints()
        {
            var specialSkillCount = 0;

            if (Form.skills1.Length > 1)
            {
                specialSkillCount++;
            }

            if (Form.skills2.Length > 1)
            {
                specialSkillCount++;
            }

            if (Form.skills3.Length > 1)
            {
                specialSkillCount++;
            }

            if (Form.skills4.Length > 1)
            {
                specialSkillCount++;
            }

            if (Form.skills5.Length > 1)
            {
                specialSkillCount++;
            }


            if (specialSkillCount >= 3)
            {
                SpecialSkillsPoints = 3;
            }
            else if(specialSkillCount > 0)
            {
                SpecialNeedsPoints = 1;
            }
            else
            {
                SpecialNeedsPoints = 0;
            }
        }

        private void CalculateExtraCurricularActivityPoints()
        {
            var extraCurricularActivityCount = 0;

            if (Form.extraCurriculars1.Length > 1)
            {
                extraCurricularActivityCount++;
            }

            if (Form.extraCurriculars2.Length > 1)
            {
                extraCurricularActivityCount++;
            }

            if (Form.extraCurriculars3.Length > 1)
            {
                extraCurricularActivityCount++;
            }

            if (Form.extraCurriculars4.Length > 1)
            {
                extraCurricularActivityCount++;
            }

            if (Form.extraCurriculars5.Length > 1)
            {
                extraCurricularActivityCount++;
            }



            if (extraCurricularActivityCount >= 5)
            {
                ExtraCurricularActivityPoints = 5;
            }
            else if (extraCurricularActivityCount == 4)
            {
                ExtraCurricularActivityPoints = 4;
            }
            else if (extraCurricularActivityCount == 3)
            {
                ExtraCurricularActivityPoints = 3;
            }
            else if (extraCurricularActivityCount == 2)
            {
                ExtraCurricularActivityPoints = 2;
            }
            else if (extraCurricularActivityCount == 1)
            {
                ExtraCurricularActivityPoints = 1;
            }
            else
            {
                ExtraCurricularActivityPoints = 0;
            }

        }

        private void CalculateSpecialNeedsPoints()
        {
            if (Form.specialNeeds.Length > 7)
            {
                SpecialNeedsPoints = 8;
            }
            else
            {
                SpecialNeedsPoints = 0;
            }
        }

        private void CalculateCompletionOfFormPoints()
        {
            if (Form.FormComplete)
            {
                CompletionOfFormPoints = 2;
            }
            else
            {
                CompletionOfFormPoints = 0;
            }
        }
    }
}