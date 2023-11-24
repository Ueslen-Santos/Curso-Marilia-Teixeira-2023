using Script;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace VMS.TPS
{
    public class Script
    {
        
        public void Execute(ScriptContext context)
        {   ////  O codigo deve estar aqui dentro (Descrito Abixo) /////


            //context.Course.Patient.

            ////////////////////////////////////////////
            ////////////////////////////////////////////
            ///    Area de Definicao e Busca dos  //////
            ///    Principais Parametros do Plano //////
            ////////////////////////////////////////////
            ////////////////////////////////////////////

            //PlanSetup planSetup = context.PlanSetup;
            //StructureSet ss = context.StructureSet;    
            //var beams = context.PlanSetup.Beams;



            int[] RPN = new int[2] { 0, 1 };      

                 //Verificacao    //Valor 0 (Falso) ou 1 (Verdadeiro)
                 //Key            //Value
            Dictionary<string, float> dicionarioCheck = new Dictionary<string, float>();







            ////////////////////////////////////////////
            ////////////////////////////////////////////
            ///           Verificacao 1           //////
            ///                                   //////
            ////////////////////////////////////////////
            ////////////////////////////////////////////
            ///Origem dicom difere de Usuario
            

            Common.Model.API.Image image = context.StructureSet.Image;


            if (image.HasUserOrigin)
            {               
                dicionarioCheck.Add("check1", RPN[1]);
            }
            else
            {             
                dicionarioCheck.Add("check1", RPN[0]);            
            }













            ////////////////////////////////////////////
            ////////////////////////////////////////////
            ///           Verificacao 2           //////
            ///                                   //////
            ////////////////////////////////////////////
            ////////////////////////////////////////////
            //"Algoritmo de calculo AcurosXB_15606 ou AAA_15606";//

            string modeloPhoton = context.PlanSetup.PhotonCalculationModel;
           
            if (modeloPhoton == "AAA_15606" || modeloPhoton == "AcurosXB_15606")
            {
                dicionarioCheck.Add("check2", RPN[1]);
            }
            else
            {
                dicionarioCheck.Add("check2", RPN[0]);
            }














            ////////////////////////////////////////////
            ////////////////////////////////////////////
            ///           Verificacao 3           //////
            ///                                   //////
            ////////////////////////////////////////////
            ////////////////////////////////////////////
            ///Todos os campos possuem bolus se inserido:
 
            var beams = context.PlanSetup.Beams;
            bool bolusInseridoBeams = true;
            foreach (var structure in context.StructureSet.Structures)
            {
                if (structure.DicomType == "BOLUS")
                {
                    foreach (var beam in beams)
                    {
                        if (beam.Boluses.Count() == 0 && !beam.IsSetupField)
                            bolusInseridoBeams = false;
                    }
                    if (bolusInseridoBeams)
                    {
                        // Campos possuem bolus
                        dicionarioCheck.Add("check3", RPN[1]);                     
                    }
                    else
                    {
                        //Algum campo não possui bolus
                        dicionarioCheck.Add("check3", RPN[0]);                     
                    }
                }
                else
                { }
            }










            ////////////////////////////////////////////
            ////////////////////////////////////////////
            ///  Comando Responsavel por mandar   //////
            ///  e Abrir a Interface              //////
            ////////////////////////////////////////////
            ////////////////////////////////////////////

            Form1 form1 = new Form1(dicionarioCheck);
            form1.ShowDialog();
        }
    }
}
