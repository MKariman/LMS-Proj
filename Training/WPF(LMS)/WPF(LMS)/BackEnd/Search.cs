﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LMS_.BackEnd
{
    public class Search
    {
        

        public List<St_Models> STFilter(string UCS)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.St_InfM.Where(i => i.UniCode.ToString().StartsWith(UCS));
                var SList = login.ToList();
                return SList;
            }
        }

        public List<Tch_Models> TchFilter(string TCS)
        {
            using(DB_Proj db=new DB_Proj())
            {
                var login = db.Tch_InfM.Where(i => i.OrgCode.ToString().StartsWith(TCS));
                var list = login.ToList();
                return list;
            }
        }

        public List<Mg_Models> MgFilter(string TCS)
        {
            using (DB_Proj db = new DB_Proj())
            {
                var login = db.Mg_InfM.Where(i => i.OrgCode.ToString().StartsWith(TCS));
                var list = login.ToList();
                return list;
            }
        }


        public Mg_Models MgSearch(int usern)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.Mg_InfM.Where
                (i => i.OrgCode == usern).FirstOrDefault();
                return login;
            }

        }

        public St_Models STSearch(int usern)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.St_InfM.Where
                (i => i.UniCode == usern).FirstOrDefault();
                return login;
            }
        }

        public Tch_Models TchSearch(int usern)
        {
            using (var Db = new DB_Proj())
            {
                var login = Db.Tch_InfM.Where
                (i => i.OrgCode == usern).FirstOrDefault();
                return login;
            }
        }



       

        public List<MajorsLessons> AuChart(string RMajor)
        {
            using(DB_Proj db=new DB_Proj())
            {
                var EkhChart = db.Lessons.Where(i => i.Major == RMajor);
                var OmChart = db.Lessons.Where(i => i.Major == "Omumi");
                var PaChart = db.Lessons.Where(i => i.Major == "Paye");
                List<MajorsLessons> MLPer = new List<MajorsLessons>();


                foreach (var item in EkhChart)
                {
                    MLPer.Add(new MajorsLessons
                    {
                        Lesson = item.Lesson,
                        Type = item.Type,
                        Unit = item.Unit

                    });

                }

                foreach (var item in OmChart)
                {
                    MLPer.Add(new MajorsLessons
                    {
                        Lesson = item.Lesson,
                        Type = item.Type,
                        Unit = item.Unit

                    });

                }
                if ((RMajor == "Computer")||(RMajor=="Barq")||(RMajor=="Omran")||(RMajor=="Mechanic")||(RMajor=="Shimi")||(RMajor== "Memari"))
                {
                    foreach (var item in PaChart)
                    {
                        MLPer.Add(new MajorsLessons
                        {
                            Lesson = item.Lesson,
                            Type = item.Type,
                            Unit = item.Unit

                        });

                    }

                }
                
                

                return MLPer;
            }
            
        }
   

        public List<Marks.CompM> CompMark(int STID)
        {
            using(DB_Proj db=new DB_Proj())
            {
                var STRow = db.St_InfM.Where(i => i.UniCode == STID).FirstOrDefault();
                var MRow = db.CompD.Where(i => i.St_ModelsId == STRow.St_ModelsId).FirstOrDefault();
                List<Marks.CompM> ComMark = new List<Marks.CompM>();
                ComMark.Add(new Marks.CompM
                {
                    CManteqi = MRow.CManteqi,
                    CDatabase = MRow.CDatabase,
                    CGosaste = MRow.CGosaste,
                    CInteligence = MRow.CInteligence,
                    CProgramming = MRow.CProgramming,
                    Riazi1 = MRow.Riazi1,
                    Adabiat = MRow.Adabiat,
                    Andishe = MRow.Andishe,
                    Moadelat = MRow.Moadelat
                });
                return ComMark;
            }
            
            
        }
        public List<Marks.BarqM> BarqMark(int STID)
        {
            using(DB_Proj db=new DB_Proj())
            {
                var STRow = db.St_InfM.Where(i => i.UniCode == STID).FirstOrDefault();
                var MRow = db.BarqD.Where(i => i.St_ModelsId == STRow.St_ModelsId).FirstOrDefault();
                List<Marks.BarqM> BarqMark = new List<Marks.BarqM>();
                BarqMark.Add(new Marks.BarqM
                {
                    BCmos = MRow.BCmos,
                    BElectro = MRow.BElectro,
                    BVLSI = MRow.BVLSI,
                    BQodrat = MRow.BQodrat,
                    BMadar = MRow.BMadar,
                    Riazi1 = MRow.Riazi1,
                    Adabiat = MRow.Adabiat,
                    Andishe = MRow.Andishe,
                    Moadelat = MRow.Moadelat ,
                    


                });
                return BarqMark;
            }
           
        }
        public List<Marks.OmranM> OmrMark(int STID)
        {
            using(DB_Proj db=new DB_Proj())
            {
                var STRow = db.St_InfM.Where(i => i.UniCode == STID).FirstOrDefault();
                var MRow = db.OmranD.Where(i => i.St_ModelsId == STRow.St_ModelsId).FirstOrDefault();
                List<Marks.OmranM> OmrMark = new List<Marks.OmranM>();
                OmrMark.Add(new Marks.OmranM
                {
                    OBotons = MRow.OBotons,
                    ODinamik = MRow.ODinamik,
                    OMasaleh = MRow.OMasaleh,
                    ONaqshe = MRow.ONaqshe,
                    OStatik = MRow.OStatik,
                    Riazi1 = MRow.Riazi1,
                    Adabiat = MRow.Adabiat,
                    Andishe = MRow.Andishe,
                    Moadelat = MRow.Moadelat,
                 
                });
               

                return OmrMark;
            }
           
        }
        public List<Marks.ShimiM> ShiMark(int STID)
        {
            using (DB_Proj db = new DB_Proj())
            {
                var STRow = db.St_InfM.Where(i => i.UniCode == STID).FirstOrDefault();
                var MRow = db.ShimiD.Where(i => i.St_ModelsId == STRow.St_ModelsId).FirstOrDefault();
                List<Marks.ShimiM> ShiMark = new List<Marks.ShimiM>();
                ShiMark.Add(new Marks.ShimiM
                {
                    SHGaz = MRow.SHGaz,
                    SHHararat = MRow.SHHararat,
                    SHJerm = MRow.SHJerm,
                    SHMavad = MRow.SHMavad,
                    SHSinema = MRow.SHSinema,
                    Riazi1 = MRow.Riazi1,
                    Adabiat = MRow.Adabiat,
                    Andishe = MRow.Andishe,
                    Moadelat = MRow.Moadelat
                });
                return ShiMark;

            }
                
        }
        public List<Marks.MechM> MechMark(int STID)
        {
            using (DB_Proj db = new DB_Proj())
            {
                var STRow = db.St_InfM.Where(i => i.UniCode == STID).FirstOrDefault();
                var MRow = db.MechD.Where(i => i.St_ModelsId == STRow.St_ModelsId).FirstOrDefault();
                List<Marks.MechM> MechMark = new List<Marks.MechM>();
                MechMark.Add(new Marks.MechM
                {
                    MControl = MRow.MControl,
                    MFizik = MRow.MFizik,
                    MMashin = MRow.MMashin,
                    MSayalat = MRow.MSayalat,
                    MTermo = MRow.MTermo,
                    Riazi1 = MRow.Riazi1,
                    Adabiat = MRow.Adabiat,
                    Andishe = MRow.Andishe,
                    Moadelat = MRow.Moadelat,
                });
                return MechMark;
            }
          
        }
        public List<Marks.MemM> MeMark(int STID)
        {
            using (DB_Proj db = new DB_Proj())
            {
                var STRow = db.St_InfM.Where(i => i.UniCode == STID).FirstOrDefault();
                var MRow = db.MemD.Where(i => i.St_ModelsId == STRow.St_ModelsId).FirstOrDefault();
                List<Marks.MemM> MeMark = new List<Marks.MemM>();
                MeMark.Add(new Marks.MemM
                {
                    MeDekor = MRow.MeDekor,
                    MeFazas = MRow.MeFazas,
                    MeNama = MRow.MeNama,
                    MeNaqshe = MRow.MeNaqshe,
                    MeTarahi = MRow.MeTarahi,
                    Adabiat = MRow.Adabiat,
                    Andishe = MRow.Andishe ,
                    Riazi1 = MRow.Riazi1
                });
                return MeMark;
            }
              
        }

        // search dar list asatid


        public List<ett> Ent(string Less, string Maj)
        {

            List<ett> Test = new List<ett>();

            using (DB_Proj db = new DB_Proj())
            {
                if (Maj == "Barq")
                {
                    var f = db.BarqD.ToList();
                    for (int i = 0; i < db.BarqD.Count() - 1; i++)
                    {
                        
                        var s = f[i].GetType().GetProperties().Where(a => a.Name == Less && a.GetValue(f[i]) != null).FirstOrDefault();
                        if (s != null)
                        {
                            var y = db.St_InfM.Where(a => a.St_ModelsId == f[i].St_ModelsId).FirstOrDefault();
                            Test.Add(new ett
                            {
                                Mark = Convert.ToInt16(s.GetValue(f[i])),
                                Lesson = Less,
                                Name = y.Name,
                                LastName = y.LastName,
                                Major = y.Major,
                                UniCode = y.UniCode,
                                Unilog = y.UniLog

                            });
                        }
                    }

                    return Test;
                }
                if (Maj == "Computer")
                {
                    var f = db.CompD.ToList();
                    for (int i = 0; i < db.CompD.Count() - 1; i++)
                    {

                        var s = f[i].GetType().GetProperties().Where(a => a.Name == Less && a.GetValue(f[i]) != null).FirstOrDefault();
                        if (s != null)
                        {
                            var y = db.St_InfM.Where(a => a.St_ModelsId == f[i].St_ModelsId).FirstOrDefault();
                            Test.Add(new ett
                            {
                                Mark = Convert.ToInt16(s.GetValue(f[i])),
                                Lesson = Less,
                                Name = y.Name,
                                LastName = y.LastName,
                                Major = y.Major,
                                UniCode = y.UniCode,
                                Unilog = y.UniLog

                            });
                        }
                    }

                    return Test;
                }
                if (Maj == "Shimi")
                {
                    var f = db.ShimiD.ToList();
                    for (int i = 0; i < db.ShimiD.Count() - 1; i++)
                    {

                        var s = f[i].GetType().GetProperties().Where(a => a.Name == Less && a.GetValue(f[i]) != null).FirstOrDefault();
                        if (s != null)
                        {
                            var y = db.St_InfM.Where(a => a.St_ModelsId == f[i].St_ModelsId).FirstOrDefault();
                            Test.Add(new ett
                            {
                                Mark = Convert.ToInt16(s.GetValue(f[i])),
                                Lesson = Less,
                                Name = y.Name,
                                LastName = y.LastName,
                                Major = y.Major,
                                UniCode = y.UniCode,
                                Unilog = y.UniLog

                            });
                        }
                    }

                    return Test;
                }
                if (Maj == "Mechanic")
                {
                    var f = db.MechD.ToList();
                    for (int i = 0; i < db.MechD.Count() - 1; i++)
                    {

                        var s = f[i].GetType().GetProperties().Where(a => a.Name == Less && a.GetValue(f[i]) != null).FirstOrDefault();
                        if (s != null)
                        {
                            var y = db.St_InfM.Where(a => a.St_ModelsId == f[i].St_ModelsId).FirstOrDefault();
                            Test.Add(new ett
                            {
                                Mark = Convert.ToInt16(s.GetValue(f[i])),
                                Lesson = Less,
                                Name = y.Name,
                                LastName = y.LastName,
                                Major = y.Major,
                                UniCode = y.UniCode,
                                Unilog = y.UniLog

                            });
                        }
                    }

                    return Test;
                }
                if (Maj == "Omran")
                {
                    var f = db.OmranD.ToList();
                    for (int i = 0; i < db.OmranD.Count() - 1; i++)
                    {

                        var s = f[i].GetType().GetProperties().Where(a => a.Name == Less && a.GetValue(f[i]) != null).FirstOrDefault();
                        if (s != null)
                        {
                            var y = db.St_InfM.Where(a => a.St_ModelsId == f[i].St_ModelsId).FirstOrDefault();
                            Test.Add(new ett
                            {
                                Mark = Convert.ToInt16(s.GetValue(f[i])),
                                Lesson = Less,
                                Name = y.Name,
                                LastName = y.LastName,
                                Major = y.Major,
                                UniCode = y.UniCode,
                                Unilog = y.UniLog

                            });
                        }
                    }

                    return Test;
                }
                if (Maj == "Memari")
                {
                    var f = db.MemD.ToList();
                    for (int i = 0; i < db.BarqD.Count() - 1; i++)
                    {

                        var s = f[i].GetType().GetProperties().Where(a => a.Name == Less && a.GetValue(f[i]) != null).FirstOrDefault();
                        if (s != null)
                        {
                            var y = db.St_InfM.Where(a => a.St_ModelsId == f[i].St_ModelsId).FirstOrDefault();
                            Test.Add(new ett
                            {
                                Mark = Convert.ToInt16(s.GetValue(f[i])),
                                Lesson = Less,
                                Name = y.Name,
                                LastName = y.LastName,
                                Major = y.Major,
                                UniCode = y.UniCode,
                                Unilog = y.UniLog

                            });
                        }
                    }

                    return Test;
                }

                return Test;
            }
        }







    }
}
