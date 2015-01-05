using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Entities;

namespace DAL
{
    public class dbOperations
    {
        #region Authentication

        public authenticateUser getUserDetails(string userName)
        {
            authenticateUser authUser = null;

            SqlParameter[] parameters = new SqlParameter[]
		        {
			        new SqlParameter("@UserName", userName)
		        };
            //Lets get the user
            using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_UserLoginSelect", CommandType.StoredProcedure, parameters))

                //check if any record exist or not
                if (table.Rows.Count == 1)
                {
                    DataRow row = table.Rows[0];

                    authUser = new authenticateUser();

                    //Now lets populate the user details  

                    authUser.userID = row["UserID"].ToString();
                    authUser.username = row["UserName"].ToString();
                    authUser.password = row["Password"].ToString();
                    authUser.role = row["Role"].ToString();
                    authUser.email = row["Email"].ToString();
                    return authUser;
                }
                else
                    return null;

        }

        #endregion



        #region Contestation

        #region Contestation

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<contestationCases> getCaseDetails(int caseNo, string pcpID, string pcpCounty, string fromDate, string toDate, string claimType, int DbID)
        {
            string spName = string.Empty;
            if (DbID == (int)_Contestation.FREEDOM)
            {
                switch (caseNo)
                {
                    case 1:
                        spName = "usp_contestation_freedom_case1";
                        break;
                    case 2:
                        spName = "usp_contestation_freedom_case2";
                        break;
                    case 3:
                        spName = "usp_contestation_freedom_case3";
                        break;
                    case 4:
                        spName = "usp_contestation_freedom_case4";
                        break;
                    case 5:
                        spName = "usp_contestation_freedom_case5";
                        break;
                    case 6:
                        spName = "usp_contestation_freedom_case6";
                        break;
                    case 7:
                        spName = "usp_contestation_freedom_case7";
                        break;
                    case 8:
                        spName = "usp_contestation_freedom_case8";
                        break;
                    case 9:
                        spName = "usp_contestation_freedom_case9";
                        break;
                    case 10:
                        spName = "usp_contestation_freedom_case10";
                        break;
                    case 11:
                        spName = "usp_contestation_freedom_case11";
                        break;
                    default:
                        spName = string.Empty;
                        break;
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                switch (caseNo)
                {
                    case 1:
                        spName = "usp_contestation_optimum_case1";
                        break;
                    case 2:
                        spName = "usp_contestation_optimum_case2";
                        break;
                    case 3:
                        spName = "usp_contestation_optimum_case3";
                        break;
                    case 4:
                        spName = "usp_contestation_optimum_case4";
                        break;
                    case 5:
                        spName = "usp_contestation_optimum_case5";
                        break;
                    case 6:
                        spName = "usp_contestation_optimum_case6";
                        break;
                    case 7:
                        spName = "usp_contestation_optimum_case7";
                        break;
                    case 8:
                        spName = "usp_contestation_optimum_case8";
                        break;
                    case 9:
                        spName = "usp_contestation_optimum_case9";
                        break;
                    case 10:
                        spName = "usp_contestation_optimum_case10";
                        break;
                    case 11:
                        spName = "usp_contestation_optimum_case11";
                        break;
                    default:
                        spName = string.Empty;
                        break;
                }

            }

            List<contestationCases> listCases = null;

            if (spName != string.Empty)
            {
                SqlParameter[] parameters = new SqlParameter[]
		            {                
			            new SqlParameter("@pcpid", pcpID),
			            new SqlParameter("@pcpcounty", pcpCounty),
			            new SqlParameter("@fromdate", fromDate),
			            new SqlParameter("@todate", toDate),
			            new SqlParameter("@claimtype", claimType)
		            };
                if (DbID == (int)_Contestation.FREEDOM)
                {
                    //Lets get the list of all case1 records in a datataable
                    using (DataTable table = FreedomDatabase.ExecuteSelectCommand(spName, CommandType.StoredProcedure, parameters))
                    {
                        //check if any record exist or not
                        if (table.Rows.Count > 0)
                        {
                            //Lets go ahead and create the list of case1 results
                            listCases = new List<contestationCases>();

                            //Now lets populate the case1 details into the list of results
                            foreach (DataRow row in table.Rows)
                            {
                                contestationCases cases = new contestationCases();

                                cases.ID = row["ID"].ToString();
                                cases.pcpID = row["PCP_ID"].ToString();
                                cases.pcpName = row["PCP_NAME"].ToString();
                                cases.subscriberID = row["SUBSCRIBER_ID"].ToString();
                                cases.memberName = row["MEMBER_NAME"].ToString();
                                cases.claimType = row["CLAIM_TYPE"].ToString();
                                cases.claimID = row["CLAIM_ID"].ToString();
                                cases.billTypePos = row["BILL_TYPE_POS"].ToString();
                                cases.serviceCode = row["SERVICE_CODE"].ToString();
                                cases.drgCode = row["DRG_CODE"].ToString();
                                cases.providerID = row["PROVIDER_ID"].ToString();
                                cases.providerName = row["PROVIDER_NAME"].ToString();
                                cases.serviceBegin = UtilityClass.getDatePart(row["SERVICE_DATE"].ToString());
                                cases.serviceEnd = UtilityClass.getDatePart(row["SERVICE_THRU_DATE"].ToString());

                                cases.checkDate = UtilityClass.getDatePart(row["CHECK_DATE"].ToString());

                                cases.serviceCodeModi = row["SERVICE_CODE_MODIFIER"].ToString();
                                cases.lineNo = row["LINE_NUMBER"].ToString();
                                cases.units = row["UNITS"].ToString();
                                cases.billedAmount = row["TOTAL_CHARGES"].ToString();
                                cases.paidAmount = row["PAID_AMOUNT"].ToString();
                                cases.reason = row["HEAD"].ToString();

                                listCases.Add(cases);
                            }
                        }
                        else
                        {
                            listCases = new List<contestationCases>();
                        }
                    }
                }
                else if (DbID == (int)_Contestation.OPTIMUM)
                {
                    //Lets get the list of all case1 records in a datataable
                    using (DataTable table = OptimumDatabase.ExecuteSelectCommand(spName, CommandType.StoredProcedure, parameters))
                    {
                        //check if any record exist or not
                        if (table.Rows.Count > 0)
                        {
                            //Lets go ahead and create the list of case1 results
                            listCases = new List<contestationCases>();

                            //Now lets populate the case1 details into the list of results
                            foreach (DataRow row in table.Rows)
                            {
                                contestationCases cases = new contestationCases();

                                cases.ID = row["ID"].ToString();
                                cases.pcpID = row["PCP_ID"].ToString();
                                cases.pcpName = row["PCP_NAME"].ToString();
                                cases.subscriberID = row["SUBSCRIBER_ID"].ToString();
                                cases.memberName = row["MEMBER_NAME"].ToString();
                                cases.claimType = row["CLAIM_TYPE"].ToString();
                                cases.claimID = row["CLAIM_ID"].ToString();
                                cases.billTypePos = row["BILL_TYPE_POS"].ToString();
                                cases.serviceCode = row["SERVICE_CODE"].ToString();
                                cases.drgCode = row["DRG_CODE"].ToString();
                                cases.providerID = row["PROVIDER_ID"].ToString();
                                cases.providerName = row["PROVIDER_NAME"].ToString();
                                cases.serviceBegin = UtilityClass.getDatePart(row["SERVICE_DATE"].ToString());
                                cases.serviceEnd = UtilityClass.getDatePart(row["SERVICE_THRU_DATE"].ToString());

                                cases.checkDate = UtilityClass.getDatePart(row["CHECK_DATE"].ToString());

                                cases.serviceCodeModi = row["SERVICE_CODE_MODIFIER"].ToString();
                                cases.lineNo = row["LINE_NUMBER"].ToString();
                                cases.units = row["UNITS"].ToString();
                                cases.billedAmount = row["TOTAL_CHARGES"].ToString();
                                cases.paidAmount = row["PAID_AMOUNT"].ToString();
                                cases.reason = row["HEAD"].ToString();

                                listCases.Add(cases);
                            }
                        }
                        else
                        {
                            listCases = new List<contestationCases>();
                        }
                    }
                }
            }
            else
            {
                listCases = new List<contestationCases>();
            }

            return listCases;

        }

        public List<pcpCounty> getPcpCounty(int DbID)
        {
            List<pcpCounty> listPcpCounty = null;

            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_PcpCountySelect", CommandType.StoredProcedure))
                {
                    if (table.Rows.Count > 0)
                    {
                        listPcpCounty = new List<pcpCounty>();

                        foreach (DataRow row in table.Rows)
                        {
                            pcpCounty county = new pcpCounty();

                            county.pcpNameCounty = row["PCP_COUNTY"].ToString();

                            listPcpCounty.Add(county);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_PcpCountySelect", CommandType.StoredProcedure))
                {
                    if (table.Rows.Count > 0)
                    {
                        listPcpCounty = new List<pcpCounty>();

                        foreach (DataRow row in table.Rows)
                        {
                            pcpCounty county = new pcpCounty();

                            county.pcpNameCounty = row["PCP_COUNTY"].ToString();

                            listPcpCounty.Add(county);
                        }
                    }
                }
            }

            return listPcpCounty;
        }

        public List<pcpNames> getPcpNames(string pcpCounty, string claimType, int DbID)
        {
            List<pcpNames> listPcpNames = null;

            SqlParameter[] parameters = new SqlParameter[]
		        {
			        new SqlParameter("@PcpCounty", pcpCounty)
			        , new SqlParameter("@ClaimType", claimType)
		        };

            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_PcpNameSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listPcpNames = new List<pcpNames>();

                        foreach (DataRow row in table.Rows)
                        {
                            pcpNames names = new pcpNames();

                            names.pcpID = row["PCP_ID"].ToString();
                            names.pcpName = row["PCP_NAME"].ToString();

                            listPcpNames.Add(names);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_PcpNameSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listPcpNames = new List<pcpNames>();

                        foreach (DataRow row in table.Rows)
                        {
                            pcpNames names = new pcpNames();

                            names.pcpID = row["PCP_ID"].ToString();
                            names.pcpName = row["PCP_NAME"].ToString();

                            listPcpNames.Add(names);
                        }
                    }
                }
            }

            return listPcpNames;
        }

        public bool insertResults(resultsObjects result, string username, string userId, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@pcpid",result.pcpID),
			    new SqlParameter("@pcpname", result.pcpName),
			    new SqlParameter("@memberid",result.subscriberID),
			    new SqlParameter("@membername", result.memberName),
			    new SqlParameter("@claimtype",result.claimType),
			    new SqlParameter("@claimid", result.claimID),
			    new SqlParameter("@billtypepos",result.billTypePos),
			    new SqlParameter("@servicecode", result.serviceCode),
			    new SqlParameter("@fromdate",result.serviceBegin),
			    new SqlParameter("@todate", result.serviceEnd),
			    new SqlParameter("@units",result.units),
			    new SqlParameter("@drgcode", result.drgCode),
			    new SqlParameter("@providerid",result.providerID),
			    new SqlParameter("@providername", result.providerName),
			    new SqlParameter("@totalcharges",result.billedAmount),
			    new SqlParameter("@paidamount", result.paidAmount),
			    new SqlParameter("@head",result.reason),
			    new SqlParameter("@username", username),
			    new SqlParameter("@userid",userId),
			    new SqlParameter("@dateofentry", DateTime.Now),
			    new SqlParameter("@check_date", result.checkDate),
			    new SqlParameter("@line_number",result.lineNo),
			    new SqlParameter("@service_code_modifier", result.serviceCodeModi),
		    };


            if (DbID == (int)_Contestation.FREEDOM)
            {
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_freedom_contestation_resultInsert", CommandType.StoredProcedure, parameters);
            }
            else
            {
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_optimum_contestation_resultInsert", CommandType.StoredProcedure, parameters);
            }
        }

        #endregion

        #region Results

        public List<resultsObjects> getCaseDetails(string fromDate, string toDate, int DbID)
        {
            List<resultsObjects> lisResults = null;
            SqlParameter[] parameters;

            parameters = new SqlParameter[]
		            {                
			            new SqlParameter("@FromDate", fromDate),
			            new SqlParameter("@ToDate", toDate)
		            };

            if (DbID == (int)_Contestation.FREEDOM)
            {
                //Lets get the list of all case1 records in a datataable
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_freedom_contestation_resultSelect", CommandType.StoredProcedure, parameters))
                {
                    //check if any record exist or not
                    if (table.Rows.Count > 0)
                    {
                        //Lets go ahead and create the list of case1 results
                        lisResults = new List<resultsObjects>();

                        //Now lets populate the case1 details into the list of results
                        foreach (DataRow row in table.Rows)
                        {
                            resultsObjects cases = new resultsObjects();

                            cases.ID = row["ID"].ToString();
                            cases.pcpID = row["pcpid"].ToString();
                            cases.pcpName = row["pcpname"].ToString();
                            cases.subscriberID = row["memberid"].ToString();
                            cases.memberName = row["membername"].ToString();
                            cases.claimType = row["claimtype"].ToString();
                            cases.claimID = row["claimid"].ToString();
                            cases.billTypePos = row["billtypepos"].ToString();
                            cases.serviceCode = row["servicecode"].ToString();
                            cases.serviceBegin = UtilityClass.getDatePart(row["fromdate"].ToString());
                            cases.serviceEnd = UtilityClass.getDatePart(row["todate"].ToString());

                            cases.serviceCodeModi = row["service_code_modifier"].ToString();
                            cases.lineNo = row["line_number"].ToString();

                            cases.units = row["units"].ToString();
                            cases.drgCode = row["drgcode"].ToString();
                            cases.providerID = row["providerid"].ToString();
                            cases.providerName = row["providername"].ToString();
                            cases.billedAmount = row["totalcharges"].ToString();
                            cases.paidAmount = row["paidamount"].ToString();
                            cases.reason = row["head"].ToString();

                            cases.checkDate = UtilityClass.getDatePart(row["check_date"].ToString());
                            cases.dateOfContest = UtilityClass.getDatePart(row["dateofentry"].ToString());

                            lisResults.Add(cases);
                        }
                    }
                    else
                    {
                        lisResults = new List<resultsObjects>();
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                //Lets get the list of all case1 records in a datataable
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_tbl_optimum_contestation_resultSelect", CommandType.StoredProcedure, parameters))
                {
                    //check if any record exist or not
                    if (table.Rows.Count > 0)
                    {
                        //Lets go ahead and create the list of case1 results
                        lisResults = new List<resultsObjects>();

                        //Now lets populate the case1 details into the list of results
                        foreach (DataRow row in table.Rows)
                        {
                            resultsObjects cases = new resultsObjects();

                            cases.ID = row["ID"].ToString();
                            cases.pcpID = row["pcpid"].ToString();
                            cases.pcpName = row["pcpname"].ToString();
                            cases.subscriberID = row["memberid"].ToString();
                            cases.memberName = row["membername"].ToString();
                            cases.claimType = row["claimtype"].ToString();
                            cases.claimID = row["claimid"].ToString();
                            cases.billTypePos = row["billtypepos"].ToString();
                            cases.serviceCode = row["servicecode"].ToString();
                            cases.serviceBegin = UtilityClass.getDatePart(row["fromdate"].ToString());
                            cases.serviceEnd = UtilityClass.getDatePart(row["todate"].ToString());

                            cases.serviceCodeModi = row["service_code_modifier"].ToString();
                            cases.lineNo = row["line_number"].ToString();

                            cases.units = row["units"].ToString();
                            cases.drgCode = row["drgcode"].ToString();
                            cases.providerID = row["providerid"].ToString();
                            cases.providerName = row["providername"].ToString();
                            cases.billedAmount = row["totalcharges"].ToString();
                            cases.paidAmount = row["paidamount"].ToString();
                            cases.reason = row["head"].ToString();

                            cases.checkDate = UtilityClass.getDatePart(row["check_date"].ToString());
                            cases.dateOfContest = UtilityClass.getDatePart(row["dateofentry"].ToString());

                            lisResults.Add(cases);
                        }
                    }
                    else
                    {
                        lisResults = new List<resultsObjects>();
                    }
                }
            }
            return lisResults;
        }

        public DataTable getCaseDetailsExcel(string fromDate, string toDate, int DbID)
        {
            SqlParameter[] parameters;

            parameters = new SqlParameter[]
		            {                
			            new SqlParameter("@FromDate", fromDate),
			            new SqlParameter("@ToDate", toDate)
		            };
            if (DbID == (int)_Contestation.FREEDOM)
            {
                //Lets get the list of all case1 records in a datataable
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_freedom_contestation_resultExcelSelect", CommandType.StoredProcedure, parameters))
                {
                    //check if any record exist or not
                    if (table.Rows.Count > 0)
                    {
                        return table;
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            else
            {
                //Lets get the list of all case1 records in a datataable
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_tbl_optimum_contestation_resultExcelSelect", CommandType.StoredProcedure, parameters))
                {
                    //check if any record exist or not
                    if (table.Rows.Count > 0)
                    {
                        return table;
                    }
                    else
                    {
                        return null;
                    }
                }
            }

        }

        #endregion

        #region Tables

        #region FlatRate

        public List<TableFlatRate> getFlatRate(string SearchName, int DbID)
        {
            List<TableFlatRate> listFlatRate = null;

            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SearchName", SearchName)
                
		    };

            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_Freedom_FlatRateSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listFlatRate = new List<TableFlatRate>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableFlatRate flatRate = new TableFlatRate();

                            flatRate.ID = row["ID"].ToString();
                            flatRate.ServiceCode = row["SERVICE_CODE"].ToString();
                            flatRate.Rate = row["RATE"].ToString();

                            listFlatRate.Add(flatRate);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_Optimum_FlatRateSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listFlatRate = new List<TableFlatRate>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableFlatRate flatRate = new TableFlatRate();

                            flatRate.ID = row["ID"].ToString();
                            flatRate.ServiceCode = row["SERVICE_CODE"].ToString();
                            flatRate.Rate = row["RATE"].ToString();

                            listFlatRate.Add(flatRate);
                        }
                    }
                }
            }

            return listFlatRate;
        }

        public bool deleteFlatRate(long ID, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ID)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_Freedom_FlatRateDelete", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Optimum_FlatRateDelete", CommandType.StoredProcedure, parameters);
        }

        public bool updateFlatRate(TableFlatRate flatRate, string username, int DbID)
        {
            //cmd.Parameters.Add("@pIntErrDescOut", SqlDbType.Int).Direction = ParameterDirection.Output;
            // int retVal = (int)cmd.Parameters["@pIntErrDescOut"].Value;

            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", flatRate.ID),
			    new SqlParameter("@SERVICE_CODE",flatRate.ServiceCode),
			    new SqlParameter("@RATE", flatRate.Rate)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_Freedom_FlatRateUpdate", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Optimum_FlatRateUpdate", CommandType.StoredProcedure, parameters);
        }

        public bool insertFlatRate(TableFlatRate flatRate, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SERVICE_CODE",flatRate.ServiceCode),
			    new SqlParameter("@RATE", flatRate.Rate),
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_Freedom_FlatRateInsert", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Optimum_FlatRateInsert", CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region FRHProfRate

        public List<TableFRHProfRate> getFRHProfRate(string SearchName, int DbID)
        {
            List<TableFRHProfRate> listFRHProfRate = null;
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SearchName", SearchName)
                
		    };

            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_FreedomProfRateSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listFRHProfRate = new List<TableFRHProfRate>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableFRHProfRate FRHProfRate = new TableFRHProfRate();

                            FRHProfRate.ID = row["ID"].ToString();
                            FRHProfRate.SERVICE_PROVIDER_NAME = row["SERVICE_PROVIDER_NAME"].ToString();
                            FRHProfRate.SERVICE_PROVIDER_ID = row["SERVICE_PROVIDER_ID"].ToString();
                            FRHProfRate.FLAT_RATE = row["FLAT_RATE"].ToString();
                            FRHProfRate.Speciality = row["Speciality"].ToString();
                            FRHProfRate.RATE = row["RATE"].ToString();

                            listFRHProfRate.Add(FRHProfRate);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_OptimumProfRateSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listFRHProfRate = new List<TableFRHProfRate>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableFRHProfRate FRHProfRate = new TableFRHProfRate();

                            FRHProfRate.ID = row["ID"].ToString();
                            FRHProfRate.SERVICE_PROVIDER_NAME = row["SERVICE_PROVIDER_NAME"].ToString();
                            FRHProfRate.SERVICE_PROVIDER_ID = row["SERVICE_PROVIDER_ID"].ToString();
                            FRHProfRate.FLAT_RATE = row["FLAT_RATE"].ToString();
                            FRHProfRate.Speciality = row["Speciality"].ToString();
                            FRHProfRate.RATE = row["RATE"].ToString();

                            listFRHProfRate.Add(FRHProfRate);
                        }
                    }
                }
            }

            return listFRHProfRate;
        }

        public bool deleteFRHProfRate(long ID, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ID)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_FreedomProfRateDelete", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_OptimumProfRateDelete", CommandType.StoredProcedure, parameters);

        }

        public bool updateFRHProfRate(TableFRHProfRate FRHProfRate, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", FRHProfRate.ID),
			    new SqlParameter("@SERVICE_PROVIDER_NAME",FRHProfRate.SERVICE_PROVIDER_NAME),
                new SqlParameter("@SERVICE_PROVIDER_ID", FRHProfRate.SERVICE_PROVIDER_ID),
                new SqlParameter("@FLAT_RATE", FRHProfRate.FLAT_RATE),
                new SqlParameter("@Speciality", FRHProfRate.Speciality),
			    new SqlParameter("@RATE", FRHProfRate.RATE)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_FreedomProfRateUpdate", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_OptimumProfRateUpdate", CommandType.StoredProcedure, parameters);
        }

        public bool insertFRHProfRate(TableFRHProfRate FRHProfRate, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SERVICE_PROVIDER_NAME",FRHProfRate.SERVICE_PROVIDER_NAME),
                new SqlParameter("@SERVICE_PROVIDER_ID", FRHProfRate.SERVICE_PROVIDER_ID),
                new SqlParameter("@FLAT_RATE", FRHProfRate.FLAT_RATE),
                new SqlParameter("@Speciality", FRHProfRate.Speciality),
			    new SqlParameter("@RATE", FRHProfRate.RATE)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_FreedomProfRateInsert", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_OptimumProfRateInsert", CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region InjuryCodes

        public List<TableInjuryCodes> getInjuryCodes(string SearchName, int DbID)
        {
            List<TableInjuryCodes> listInjuryCodes = null;
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SearchName", SearchName)
                
		    };

            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_tbl_ConUNIInjuryCodesSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listInjuryCodes = new List<TableInjuryCodes>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableInjuryCodes InjuryCodes = new TableInjuryCodes();

                            InjuryCodes.ID = row["ID"].ToString();
                            InjuryCodes.InjuryCode = row["InjuryCode"].ToString();
                            InjuryCodes.InjuryCodeDesc = row["InjuryCodeDesc"].ToString();
                            InjuryCodes.InjuryCodeShortDesc = row["InjuryCodeShortDesc"].ToString();

                            listInjuryCodes.Add(InjuryCodes);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_tbl_ConOptInjuryCodesSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listInjuryCodes = new List<TableInjuryCodes>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableInjuryCodes InjuryCodes = new TableInjuryCodes();

                            InjuryCodes.ID = row["ID"].ToString();
                            InjuryCodes.InjuryCode = row["InjuryCode"].ToString();
                            InjuryCodes.InjuryCodeDesc = row["InjuryCodeDesc"].ToString();
                            InjuryCodes.InjuryCodeShortDesc = row["InjuryCodeShortDesc"].ToString();

                            listInjuryCodes.Add(InjuryCodes);
                        }
                    }
                }
            }

            return listInjuryCodes;
        }

        public bool deleteInjuryCodes(long ID, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ID)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_ConUNIInjuryCodesDelete", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_ConOptInjuryCodesDelete", CommandType.StoredProcedure, parameters);
        }

        public bool updateInjuryCodes(TableInjuryCodes InjuryCodes, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", InjuryCodes.ID),
			    new SqlParameter("@InjuryCode",InjuryCodes.InjuryCode),
			    new SqlParameter("@InjuryCodeDesc", InjuryCodes.InjuryCodeDesc),
			    new SqlParameter("@InjuryCodeShortDesc", InjuryCodes.InjuryCodeShortDesc)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_ConUNIInjuryCodesUpdate", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_ConOptInjuryCodesUpdate", CommandType.StoredProcedure, parameters);
        }

        public bool insertInjuryCodes(TableInjuryCodes InjuryCodes, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@InjuryCode",InjuryCodes.InjuryCode),
			    new SqlParameter("@InjuryCodeDesc", InjuryCodes.InjuryCodeDesc),
			    new SqlParameter("@InjuryCodeShortDesc", InjuryCodes.InjuryCodeShortDesc)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_ConUNIInjuryCodesInsert", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_ConOptInjuryCodesInsert", CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region MVA_FRH

        public List<TableMVA_FRH> getMVA_FRH(string SearchName, int DbID)
        {
            List<TableMVA_FRH> listMVA_FRH = null;
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SearchName", SearchName)
                
		    };
            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_freedom_mvaSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listMVA_FRH = new List<TableMVA_FRH>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableMVA_FRH MVA_FRH = new TableMVA_FRH();

                            MVA_FRH.ID = row["ID"].ToString();
                            MVA_FRH.PCP_NAME = row["PCP_NAME"].ToString();
                            MVA_FRH.PCP_ID = row["PCP_ID"].ToString();
                            MVA_FRH.SUBSCRIBER_ID = row["SUBSCRIBER_ID"].ToString();
                            MVA_FRH.MEMBER_NAME = row["MEMBER_NAME"].ToString();
                            MVA_FRH.DOS = UtilityClass.getDatePart(row["DOS"].ToString());

                            listMVA_FRH.Add(MVA_FRH);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_Optimum_mvaSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listMVA_FRH = new List<TableMVA_FRH>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableMVA_FRH MVA_FRH = new TableMVA_FRH();

                            MVA_FRH.ID = row["ID"].ToString();
                            MVA_FRH.PCP_NAME = row["PCP_NAME"].ToString();
                            MVA_FRH.PCP_ID = row["PCP_ID"].ToString();
                            MVA_FRH.SUBSCRIBER_ID = row["SUBSCRIBER_ID"].ToString();
                            MVA_FRH.MEMBER_NAME = row["MEMBER_NAME"].ToString();
                            MVA_FRH.DOS = UtilityClass.getDatePart(row["DOS"].ToString());

                            listMVA_FRH.Add(MVA_FRH);
                        }
                    }
                }
            }

            return listMVA_FRH;
        }

        public bool deleteMVA_FRH(long ID, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ID)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_freedom_mvaDelete", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Optimum_mvaDelete", CommandType.StoredProcedure, parameters);
        }

        public bool updateMVA_FRH(TableMVA_FRH MVA_FRH, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", MVA_FRH.ID),
			    new SqlParameter("@PCP_NAME",MVA_FRH.PCP_NAME),
			    new SqlParameter("@PCP_ID", MVA_FRH.PCP_ID),
			    new SqlParameter("@SUBSCRIBER_ID", MVA_FRH.SUBSCRIBER_ID),
			    new SqlParameter("@MEMBER_NAME", MVA_FRH.MEMBER_NAME),
			    new SqlParameter("@DOS", MVA_FRH.DOS)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_freedom_mvaUpdate", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Optimum_mvaUpdate", CommandType.StoredProcedure, parameters);
        }

        public bool insertMVA_FRH(TableMVA_FRH MVA_FRH, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@PCP_NAME",MVA_FRH.PCP_NAME),
			    new SqlParameter("@PCP_ID", MVA_FRH.PCP_ID),
			    new SqlParameter("@SUBSCRIBER_ID", MVA_FRH.SUBSCRIBER_ID),
			    new SqlParameter("@MEMBER_NAME", MVA_FRH.MEMBER_NAME),
			    new SqlParameter("@DOS", MVA_FRH.DOS)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_freedom_mvaInsert", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Optimum_mvaInsert", CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region MVAAccidentCodes

        public List<TableMVAAccidentCodes> getMVAAccidentCodes(string SearchName, int DbID)
        {
            List<TableMVAAccidentCodes> listMVAAccidentCodes = null;
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SearchName", SearchName)
                
		    };

            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_tbl_contFrdmMVACodeSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listMVAAccidentCodes = new List<TableMVAAccidentCodes>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableMVAAccidentCodes MVAAccidentCodes = new TableMVAAccidentCodes();

                            MVAAccidentCodes.ID = row["ID"].ToString();
                            MVAAccidentCodes.ICDCodes = row["ICDCodes"].ToString();
                            MVAAccidentCodes.LongDescription = row["LongDescription"].ToString();
                            MVAAccidentCodes.ShortDescription = row["ShortDescription"].ToString();

                            listMVAAccidentCodes.Add(MVAAccidentCodes);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_tbl_contOptMVACodeSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listMVAAccidentCodes = new List<TableMVAAccidentCodes>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableMVAAccidentCodes MVAAccidentCodes = new TableMVAAccidentCodes();

                            MVAAccidentCodes.ID = row["ID"].ToString();
                            MVAAccidentCodes.ICDCodes = row["ICDCodes"].ToString();
                            MVAAccidentCodes.LongDescription = row["LongDescription"].ToString();
                            MVAAccidentCodes.ShortDescription = row["ShortDescription"].ToString();

                            listMVAAccidentCodes.Add(MVAAccidentCodes);
                        }
                    }
                }
            }

            return listMVAAccidentCodes;
        }

        public bool deleteMVAAccidentCodes(long ID, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ID)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_contFrdmMVACodeDelete", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_contOptMVACodeDelete", CommandType.StoredProcedure, parameters);
        }

        public bool updateMVAAccidentCodes(TableMVAAccidentCodes MVAAccidentCodes, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", MVAAccidentCodes .ID),
			    new SqlParameter("@ICDCodes",MVAAccidentCodes .ICDCodes),
			    new SqlParameter("@LongDescription", MVAAccidentCodes .LongDescription),
			    new SqlParameter("@ShortDescription", MVAAccidentCodes .ShortDescription)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_contFrdmMVACodeUpdate", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_contOptMVACodeUpdate", CommandType.StoredProcedure, parameters);
        }

        public bool insertMVAAccidentCodes(TableMVAAccidentCodes MVAAccidentCodes, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ICDCodes",MVAAccidentCodes .ICDCodes),
			    new SqlParameter("@LongDescription", MVAAccidentCodes .LongDescription),
			    new SqlParameter("@ShortDescription", MVAAccidentCodes .ShortDescription)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_contFrdmMVACodeInsert", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_contOptMVACodeInsert", CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region UniPcpDetails

        public List<TableUniPcpDetails> getUniPcpDetails(string SearchName, int DbID)
        {
            List<TableUniPcpDetails> listUniPcpDetails = null;
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SearchName", SearchName)
                
		    };

            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_Freedom_ConUniDetailsSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listUniPcpDetails = new List<TableUniPcpDetails>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableUniPcpDetails UniPcpDetails = new TableUniPcpDetails();

                            UniPcpDetails.ID = row["ID"].ToString();
                            UniPcpDetails.PCPID = row["PCPID"].ToString();
                            UniPcpDetails.PCPName = row["PCPName"].ToString();
                            UniPcpDetails.County = row["County"].ToString();
                            UniPcpDetails.EffectiveDate = UtilityClass.getDatePart(row["EffectiveDate"].ToString());
                            UniPcpDetails.TerminatedDate = UtilityClass.getDatePart(row["TerminatedDate"].ToString());
                            UniPcpDetails.Status = row["Status"].ToString();
                            UniPcpDetails.FeeScheduleLOC = row["FeeScheduleLOC"].ToString();
                            UniPcpDetails.IPAName = row["IPAName"].ToString();
                            UniPcpDetails.PlanName = row["PlanName"].ToString();

                            listUniPcpDetails.Add(UniPcpDetails);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_Optimum_ConUniDetailsSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listUniPcpDetails = new List<TableUniPcpDetails>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableUniPcpDetails UniPcpDetails = new TableUniPcpDetails();

                            UniPcpDetails.ID = row["ID"].ToString();
                            UniPcpDetails.PCPID = row["PCPID"].ToString();
                            UniPcpDetails.PCPName = row["PCPName"].ToString();
                            UniPcpDetails.County = row["County"].ToString();
                            UniPcpDetails.EffectiveDate = UtilityClass.getDatePart(row["EffectiveDate"].ToString());
                            UniPcpDetails.TerminatedDate = UtilityClass.getDatePart(row["TerminatedDate"].ToString());
                            UniPcpDetails.Status = row["Status"].ToString();
                            UniPcpDetails.FeeScheduleLOC = row["FeeScheduleLOC"].ToString();
                            UniPcpDetails.IPAName = row["IPAName"].ToString();
                            UniPcpDetails.PlanName = row["PlanName"].ToString();

                            listUniPcpDetails.Add(UniPcpDetails);
                        }
                    }
                }
            }
            return listUniPcpDetails;
        }

        public bool deleteUniPcpDetails(long ID, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ID)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_Freedom_ConUniDetailsDelete", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Optimum_ConUniDetailsDelete", CommandType.StoredProcedure, parameters);
        }

        public bool updateUniPcpDetails(TableUniPcpDetails UniPcpDetails, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", UniPcpDetails.ID),
			    new SqlParameter("@PCPID",UniPcpDetails.PCPID),
                new SqlParameter("@PCPName",UniPcpDetails.PCPName),
			    new SqlParameter("@County", UniPcpDetails.County),
			    new SqlParameter("@EffectiveDate", UniPcpDetails.EffectiveDate),
			    new SqlParameter("@TerminatedDate", UniPcpDetails.TerminatedDate),
			    new SqlParameter("@Status",UniPcpDetails.Status),
			    new SqlParameter("@FeeScheduleLOC", UniPcpDetails.FeeScheduleLOC),
			    new SqlParameter("@IPAName", UniPcpDetails.IPAName),
			    new SqlParameter("@PlanName", UniPcpDetails.PlanName)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_Freedom_ConUniDetailsUpdate", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Optimum_ConUniDetailsUpdate", CommandType.StoredProcedure, parameters);
        }

        public bool insertUniPcpDetails(TableUniPcpDetails UniPcpDetails, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@PCPID",UniPcpDetails.PCPID),
			    new SqlParameter("@PCPName",UniPcpDetails.PCPName),
			    new SqlParameter("@County", UniPcpDetails.County),
			    new SqlParameter("@EffectiveDate", UniPcpDetails.EffectiveDate),
			    new SqlParameter("@TerminatedDate", UniPcpDetails.TerminatedDate),
			    new SqlParameter("@Status",UniPcpDetails.Status),
			    new SqlParameter("@FeeScheduleLOC", UniPcpDetails.FeeScheduleLOC),
			    new SqlParameter("@IPAName", UniPcpDetails.IPAName),
			    new SqlParameter("@PlanName", UniPcpDetails.PlanName)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_Freedom_ConUniDetailsInsert", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Optimum_ConUniDetailsInsert", CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region UniProfClaimFeeSchedule

        public List<TableUniProfClaimFeeSchedule> getUniProfClaimFeeSchedule(string SearchName, int DbID)
        {
            List<TableUniProfClaimFeeSchedule> listUniProfClaimFeeSchedule = null;
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SearchName", SearchName)
                
		    };

            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_UniFeeSceduleSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listUniProfClaimFeeSchedule = new List<TableUniProfClaimFeeSchedule>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableUniProfClaimFeeSchedule UniProfClaimFeeSchedule = new TableUniProfClaimFeeSchedule();

                            UniProfClaimFeeSchedule.ID = row["ID"].ToString();
                            UniProfClaimFeeSchedule.PeriodFrom = UtilityClass.getDatePart(row["PeriodFrom"].ToString());
                            UniProfClaimFeeSchedule.PeriodTo = UtilityClass.getDatePart(row["PeriodTo"].ToString());
                            UniProfClaimFeeSchedule.procedure = row["procedure"].ToString();
                            UniProfClaimFeeSchedule.modifier = row["modifier"].ToString();
                            UniProfClaimFeeSchedule.ParAllow = row["par_allow"].ToString();
                            UniProfClaimFeeSchedule.Locality = row["Locality"].ToString();

                            listUniProfClaimFeeSchedule.Add(UniProfClaimFeeSchedule);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_OptimumFeeSceduleSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listUniProfClaimFeeSchedule = new List<TableUniProfClaimFeeSchedule>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableUniProfClaimFeeSchedule UniProfClaimFeeSchedule = new TableUniProfClaimFeeSchedule();

                            UniProfClaimFeeSchedule.ID = row["ID"].ToString();
                            UniProfClaimFeeSchedule.PeriodFrom = UtilityClass.getDatePart(row["PeriodFrom"].ToString());
                            UniProfClaimFeeSchedule.PeriodTo = UtilityClass.getDatePart(row["PeriodTo"].ToString());
                            UniProfClaimFeeSchedule.procedure = row["procedure"].ToString();
                            UniProfClaimFeeSchedule.modifier = row["modifier"].ToString();
                            UniProfClaimFeeSchedule.ParAllow = row["par_allow"].ToString();
                            UniProfClaimFeeSchedule.Locality = row["Locality"].ToString();

                            listUniProfClaimFeeSchedule.Add(UniProfClaimFeeSchedule);
                        }
                    }
                }
            }

            return listUniProfClaimFeeSchedule;
        }

        public bool deleteUniProfClaimFeeSchedule(long ID, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ID)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_UniFeeSceduleDelete", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_OptimumFeeSceduleDelete", CommandType.StoredProcedure, parameters);
        }

        public bool updateUniProfClaimFeeSchedule(TableUniProfClaimFeeSchedule UniProfClaimFeeSchedule, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", UniProfClaimFeeSchedule.ID),
			    new SqlParameter("@Period_From",UniProfClaimFeeSchedule.PeriodFrom),
			    new SqlParameter("@Period_To", UniProfClaimFeeSchedule.PeriodTo),
			    new SqlParameter("@procedure", UniProfClaimFeeSchedule.procedure),
			    new SqlParameter("@modifier", UniProfClaimFeeSchedule.modifier),
			    new SqlParameter("@par_allow", UniProfClaimFeeSchedule.ParAllow),
			    new SqlParameter("@Locality",UniProfClaimFeeSchedule.Locality)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_UniFeeSceduleUpdate", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_OptimumFeeSceduleUpdate", CommandType.StoredProcedure, parameters);
        }

        public bool insertUniProfClaimFeeSchedule(TableUniProfClaimFeeSchedule UniProfClaimFeeSchedule, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@Period_From",UniProfClaimFeeSchedule.PeriodFrom),
			    new SqlParameter("@Period_To", UniProfClaimFeeSchedule.PeriodTo),
			    new SqlParameter("@procedure", UniProfClaimFeeSchedule.procedure),
			    new SqlParameter("@modifier", UniProfClaimFeeSchedule.modifier),
			    new SqlParameter("@par_allow", UniProfClaimFeeSchedule.ParAllow),
			    new SqlParameter("@Locality",UniProfClaimFeeSchedule.Locality)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_UniFeeSceduleInsert", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_OptimumFeeSceduleInsert", CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region FreedomCensus

        public List<TableFreedomCensus> getFreedomCensus(string SearchName, int DbID)
        {
            List<TableFreedomCensus> listFreedomCensus = null;
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SearchName", SearchName)
                
		    };

            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_tbl_Freedom_CensusSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listFreedomCensus = new List<TableFreedomCensus>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableFreedomCensus FreedomCensus = new TableFreedomCensus();

                            FreedomCensus.ID = row["ID"].ToString();
                            FreedomCensus.PCP_Name = row["PCP_Name"].ToString();
                            FreedomCensus.Member_Name = row["Member_Name"].ToString();
                            FreedomCensus.Member_ID = row["Member_ID"].ToString();
                            FreedomCensus.Admit_Date = UtilityClass.getDatePart(row["Admit_Date"].ToString());
                            FreedomCensus.Discharge_Date = UtilityClass.getDatePart(row["Discharge_Date"].ToString());
                            FreedomCensus.Admit_Diagnosis = row["Admit_Diagnosis"].ToString();
                            FreedomCensus.Facility_Name = row["Facility_Name"].ToString();

                            listFreedomCensus.Add(FreedomCensus);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_tbl_Optimum_CensusSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listFreedomCensus = new List<TableFreedomCensus>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableFreedomCensus FreedomCensus = new TableFreedomCensus();

                            FreedomCensus.ID = row["ID"].ToString();
                            FreedomCensus.PCP_Name = row["PCP_Name"].ToString();
                            FreedomCensus.Member_Name = row["Member_Name"].ToString();
                            FreedomCensus.Member_ID = row["Member_ID"].ToString();
                            FreedomCensus.Admit_Date = UtilityClass.getDatePart(row["Admit_Date"].ToString());
                            FreedomCensus.Discharge_Date = UtilityClass.getDatePart(row["Discharge_Date"].ToString());
                            FreedomCensus.Admit_Diagnosis = row["Admit_Diagnosis"].ToString();
                            FreedomCensus.Facility_Name = row["Facility_Name"].ToString();

                            listFreedomCensus.Add(FreedomCensus);
                        }
                    }
                }
            }
            return listFreedomCensus;
        }

        public bool deleteFreedomCensus(long ID, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ID)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_Freedom_CensusDelete", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_Optimum_CensusDelete", CommandType.StoredProcedure, parameters);
        }

        public bool updateFreedomCensus(TableFreedomCensus FreedomCensus, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", FreedomCensus.ID),
			    new SqlParameter("@PCP_Name",FreedomCensus.PCP_Name),
			    new SqlParameter("@Member_Name", FreedomCensus.Member_Name),
			    new SqlParameter("@Member_ID", FreedomCensus.Member_ID),
			    new SqlParameter("@Admit_Date", FreedomCensus.Admit_Date),
			    new SqlParameter("@Discharge_Date", FreedomCensus.Discharge_Date),
			    new SqlParameter("@Admit_Diagnosis",FreedomCensus.Admit_Diagnosis),
			    new SqlParameter("@Facility_Name",FreedomCensus.Facility_Name)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_Freedom_CensusUpdate", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_Optimum_CensusUpdate", CommandType.StoredProcedure, parameters);
        }

        public bool insertFreedomCensus(TableFreedomCensus FreedomCensus, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@PCP_Name",FreedomCensus.PCP_Name),
			    new SqlParameter("@Member_Name", FreedomCensus.Member_Name),
			    new SqlParameter("@Member_ID", FreedomCensus.Member_ID),
			    new SqlParameter("@Admit_Date", FreedomCensus.Admit_Date),
			    new SqlParameter("@Discharge_Date", FreedomCensus.Discharge_Date),
			    new SqlParameter("@Admit_Diagnosis",FreedomCensus.Admit_Diagnosis),
			    new SqlParameter("@Facility_Name",FreedomCensus.Facility_Name)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_Freedom_CensusInsert", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_Optimum_CensusInsert", CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region FRQuestCarveOut

        public List<TableFRQuestCarveOut> getFRQuestCarveOut(string SearchName, int DbID)
        {
            List<TableFRQuestCarveOut> listFRQuestCarveOut = null;
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SearchName", SearchName)
                
		    };

            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_FR_quest_carve_outSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listFRQuestCarveOut = new List<TableFRQuestCarveOut>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableFRQuestCarveOut FRQuestCarveOut = new TableFRQuestCarveOut();

                            FRQuestCarveOut.ID = row["ID"].ToString();
                            FRQuestCarveOut.CPT_CODE = row["CPT_CODE"].ToString();
                            FRQuestCarveOut.REIM_AMOUNT = row["REIM_AMOUNT"].ToString();
                            FRQuestCarveOut.EFF_YEAR = row["EFF_YEAR"].ToString();

                            listFRQuestCarveOut.Add(FRQuestCarveOut);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_Opt_ quest_carve_outSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listFRQuestCarveOut = new List<TableFRQuestCarveOut>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableFRQuestCarveOut FRQuestCarveOut = new TableFRQuestCarveOut();

                            FRQuestCarveOut.ID = row["ID"].ToString();
                            FRQuestCarveOut.CPT_CODE = row["CPT_CODE"].ToString();
                            FRQuestCarveOut.REIM_AMOUNT = row["REIM_AMOUNT"].ToString();
                            FRQuestCarveOut.EFF_YEAR = row["EFF_YEAR"].ToString();

                            listFRQuestCarveOut.Add(FRQuestCarveOut);
                        }
                    }
                }
            }

            return listFRQuestCarveOut;
        }

        public bool deleteFRQuestCarveOut(long ID, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ID)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_FR_quest_carve_outDelete", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Opt_ quest_carve_outDelete", CommandType.StoredProcedure, parameters);
        }

        public bool updateFRQuestCarveOut(TableFRQuestCarveOut FRQuestCarveOut, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", FRQuestCarveOut.ID),
			    new SqlParameter("@CPT_CODE",FRQuestCarveOut.CPT_CODE),
			    new SqlParameter("@REIM_AMOUNT", FRQuestCarveOut.REIM_AMOUNT),
			    new SqlParameter("@EFF_YEAR", FRQuestCarveOut.EFF_YEAR)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_FR_quest_carve_outUpdate", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Opt_ quest_carve_outUpdate", CommandType.StoredProcedure, parameters);
        }

        public bool insertFRQuestCarveOut(TableFRQuestCarveOut FRQuestCarveOut, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@CPT_CODE",FRQuestCarveOut.CPT_CODE),
			    new SqlParameter("@REIM_AMOUNT", FRQuestCarveOut.REIM_AMOUNT),
			    new SqlParameter("@EFF_YEAR", FRQuestCarveOut.EFF_YEAR)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_FR_quest_carve_outInsert", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Opt_ quest_carve_outInsert", CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region ModifierListPayment

        public List<TableModifierListPayment> getModifierListPayment(string SearchName, int DbID)
        {
            List<TableModifierListPayment> listModifierListPayment = null;
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SearchName", SearchName)
                
		    };

            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_Modifier_List_PaymentSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listModifierListPayment = new List<TableModifierListPayment>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableModifierListPayment ModifierListPayment = new TableModifierListPayment();

                            ModifierListPayment.ID = row["ID"].ToString();
                            ModifierListPayment.Modifier = row["Modifier"].ToString();
                            ModifierListPayment.Allowance = row["Allowance"].ToString();

                            listModifierListPayment.Add(ModifierListPayment);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_Optimum_Modifier_List_PaymentSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listModifierListPayment = new List<TableModifierListPayment>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableModifierListPayment ModifierListPayment = new TableModifierListPayment();

                            ModifierListPayment.ID = row["ID"].ToString();
                            ModifierListPayment.Modifier = row["Modifier"].ToString();
                            ModifierListPayment.Allowance = row["Allowance"].ToString();

                            listModifierListPayment.Add(ModifierListPayment);
                        }
                    }
                }
            }
            return listModifierListPayment;
        }

        public bool deleteModifierListPayment(long ID, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ID)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_Modifier_List_PaymentDelete", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Optimum_Modifier_List_PaymentDelete", CommandType.StoredProcedure, parameters);
        }

        public bool updateModifierListPayment(TableModifierListPayment ModifierListPayment, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ModifierListPayment.ID),
			    new SqlParameter("@Modifier",ModifierListPayment.Modifier),
			    new SqlParameter("@Allowance", ModifierListPayment.Allowance)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_Modifier_List_PaymentUpdate", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Optimum_Modifier_List_PaymentUpdate", CommandType.StoredProcedure, parameters);
        }

        public bool insertModifierListPayment(TableModifierListPayment ModifierListPayment, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@Modifier",ModifierListPayment.Modifier),
			    new SqlParameter("@Allowance", ModifierListPayment.Allowance)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_Modifier_List_PaymentInsert", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_Optimum_Modifier_List_PaymentInsert", CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region ContFrdmCapitatedProviders

        public List<TableContFrdmCapitatedProviders> getContFrdmCapitatedProviders(string SearchName, int DbID)
        {
            List<TableContFrdmCapitatedProviders> listContFrdmCapitatedProviders = null;
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SearchName", SearchName)
                
		    };

            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_tbl_contFrdmCapitatedProvidersSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listContFrdmCapitatedProviders = new List<TableContFrdmCapitatedProviders>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableContFrdmCapitatedProviders ContFrdmCapitatedProviders = new TableContFrdmCapitatedProviders();

                            ContFrdmCapitatedProviders.ID = row["ID"].ToString();
                            ContFrdmCapitatedProviders.CapitatedProviders = row["CapitatedProviders"].ToString();
                            ContFrdmCapitatedProviders.ProviderID = row["ProviderID"].ToString();
                            ContFrdmCapitatedProviders.PlanNumber = row["PlanNumber"].ToString();
                            ContFrdmCapitatedProviders.IPAName = row["IPAName"].ToString();
                            ContFrdmCapitatedProviders.PlanName = row["PlanName"].ToString();
                            ContFrdmCapitatedProviders.From_Date = UtilityClass.getDatePart(row["From_Date"].ToString());
                            ContFrdmCapitatedProviders.To_Date = UtilityClass.getDatePart(row["To_Date"].ToString());
                            ContFrdmCapitatedProviders.Speciality_name = row["Speciality_name"].ToString();
                            ContFrdmCapitatedProviders.Speciality_fund = row["Speciality_fund"].ToString();

                            listContFrdmCapitatedProviders.Add(ContFrdmCapitatedProviders);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_tbl_contOptCapitatedProvidersSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listContFrdmCapitatedProviders = new List<TableContFrdmCapitatedProviders>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableContFrdmCapitatedProviders ContFrdmCapitatedProviders = new TableContFrdmCapitatedProviders();

                            ContFrdmCapitatedProviders.ID = row["ID"].ToString();
                            ContFrdmCapitatedProviders.CapitatedProviders = row["CapitatedProviders"].ToString();
                            ContFrdmCapitatedProviders.ProviderID = row["ProviderID"].ToString();
                            ContFrdmCapitatedProviders.PlanNumber = row["PlanNumber"].ToString();
                            ContFrdmCapitatedProviders.IPAName = row["IPAName"].ToString();
                            ContFrdmCapitatedProviders.PlanName = row["PlanName"].ToString();
                            ContFrdmCapitatedProviders.From_Date = UtilityClass.getDatePart(row["From_Date"].ToString());
                            ContFrdmCapitatedProviders.To_Date = UtilityClass.getDatePart(row["To_Date"].ToString());
                            ContFrdmCapitatedProviders.Speciality_name = row["Speciality_name"].ToString();
                            ContFrdmCapitatedProviders.Speciality_fund = row["Speciality_fund"].ToString();

                            listContFrdmCapitatedProviders.Add(ContFrdmCapitatedProviders);
                        }
                    }
                }
            }

            return listContFrdmCapitatedProviders;
        }

        public bool deleteContFrdmCapitatedProviders(long ID, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ID)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_contFrdmCapitatedProvidersDelete", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_contOptCapitatedProvidersDelete", CommandType.StoredProcedure, parameters);
        }

        public bool updateContFrdmCapitatedProviders(TableContFrdmCapitatedProviders ContFrdmCapitatedProviders, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ContFrdmCapitatedProviders.ID),
			    new SqlParameter("@CapitatedProviders",ContFrdmCapitatedProviders.CapitatedProviders),
			    new SqlParameter("@ProviderID", ContFrdmCapitatedProviders.ProviderID),
			    new SqlParameter("@PlanNumber", ContFrdmCapitatedProviders.PlanNumber),
			    new SqlParameter("@IPAName", ContFrdmCapitatedProviders.IPAName),
			    new SqlParameter("@PlanName", ContFrdmCapitatedProviders.PlanName),
			    new SqlParameter("@From_Date",ContFrdmCapitatedProviders.From_Date),
			    new SqlParameter("@To_Date",ContFrdmCapitatedProviders.To_Date),
			    new SqlParameter("@Speciality_name",ContFrdmCapitatedProviders.Speciality_name),
			    new SqlParameter("@Speciality_fund",ContFrdmCapitatedProviders.Speciality_fund)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_contFrdmCapitatedProvidersUpdate", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_contOptCapitatedProvidersUpdate", CommandType.StoredProcedure, parameters);
        }

        public bool insertContFrdmCapitatedProviders(TableContFrdmCapitatedProviders ContFrdmCapitatedProviders, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@CapitatedProviders",ContFrdmCapitatedProviders.CapitatedProviders),
			    new SqlParameter("@ProviderID", ContFrdmCapitatedProviders.ProviderID),
			    new SqlParameter("@PlanNumber", ContFrdmCapitatedProviders.PlanNumber),
			    new SqlParameter("@IPAName", ContFrdmCapitatedProviders.IPAName),
			    new SqlParameter("@PlanName", ContFrdmCapitatedProviders.PlanName),
			    new SqlParameter("@From_Date",ContFrdmCapitatedProviders.From_Date),
			    new SqlParameter("@To_Date",ContFrdmCapitatedProviders.To_Date),
			    new SqlParameter("@Speciality_name",ContFrdmCapitatedProviders.Speciality_name),
			    new SqlParameter("@Speciality_fund",ContFrdmCapitatedProviders.Speciality_fund)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_contFrdmCapitatedProvidersInsert", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_contOptCapitatedProvidersInsert", CommandType.StoredProcedure, parameters);
        }

        #endregion

        #region ConUNIAnesthesiaFeeSchedule

        public List<TableConUNIAnesthesiaFeeSchedule> getConUNIAnesthesiaFeeSchedule(string SearchName, int DbID)
        {
            List<TableConUNIAnesthesiaFeeSchedule> listConUNIAnesthesiaFeeSchedule = null;
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@SearchName", SearchName)
                
		    };

            if (DbID == (int)_Contestation.FREEDOM)
            {
                using (DataTable table = FreedomDatabase.ExecuteSelectCommand("usp_tbl_ConUNIAnesthesiaFeeScheduleSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listConUNIAnesthesiaFeeSchedule = new List<TableConUNIAnesthesiaFeeSchedule>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableConUNIAnesthesiaFeeSchedule ConUNIAnesthesiaFeeSchedule = new TableConUNIAnesthesiaFeeSchedule();

                            ConUNIAnesthesiaFeeSchedule.ID = row["ID"].ToString();
                            ConUNIAnesthesiaFeeSchedule.FromDate = UtilityClass.getDatePart(row["FromDate"].ToString());
                            ConUNIAnesthesiaFeeSchedule.ToDate = UtilityClass.getDatePart(row["ToDate"].ToString());
                            ConUNIAnesthesiaFeeSchedule.ProcedureCode = row["ProcedureCode"].ToString();
                            ConUNIAnesthesiaFeeSchedule.Unit = row["Unit"].ToString();
                            ConUNIAnesthesiaFeeSchedule.ParAllow = row["ParAllow"].ToString();
                            ConUNIAnesthesiaFeeSchedule.Locality = row["Locality"].ToString();
                            ConUNIAnesthesiaFeeSchedule.IPA_NAME = row["IPA_NAME"].ToString();
                            ConUNIAnesthesiaFeeSchedule.PlanName = row["PlanName"].ToString();

                            listConUNIAnesthesiaFeeSchedule.Add(ConUNIAnesthesiaFeeSchedule);
                        }
                    }
                }
            }
            else if (DbID == (int)_Contestation.OPTIMUM)
            {
                using (DataTable table = OptimumDatabase.ExecuteSelectCommand("usp_tbl_ConOptAnesthesiaFeeScheduleSelect", CommandType.StoredProcedure, parameters))
                {
                    if (table.Rows.Count > 0)
                    {
                        listConUNIAnesthesiaFeeSchedule = new List<TableConUNIAnesthesiaFeeSchedule>();

                        foreach (DataRow row in table.Rows)
                        {
                            TableConUNIAnesthesiaFeeSchedule ConUNIAnesthesiaFeeSchedule = new TableConUNIAnesthesiaFeeSchedule();

                            ConUNIAnesthesiaFeeSchedule.ID = row["ID"].ToString();
                            ConUNIAnesthesiaFeeSchedule.FromDate = UtilityClass.getDatePart(row["FromDate"].ToString());
                            ConUNIAnesthesiaFeeSchedule.ToDate = UtilityClass.getDatePart(row["ToDate"].ToString());
                            ConUNIAnesthesiaFeeSchedule.ProcedureCode = row["ProcedureCode"].ToString();
                            ConUNIAnesthesiaFeeSchedule.Unit = row["Unit"].ToString();
                            ConUNIAnesthesiaFeeSchedule.ParAllow = row["ParAllow"].ToString();
                            ConUNIAnesthesiaFeeSchedule.Locality = row["Locality"].ToString();
                            ConUNIAnesthesiaFeeSchedule.IPA_NAME = row["IPA_NAME"].ToString();
                            ConUNIAnesthesiaFeeSchedule.PlanName = row["PlanName"].ToString();

                            listConUNIAnesthesiaFeeSchedule.Add(ConUNIAnesthesiaFeeSchedule);
                        }
                    }
                }
            }

            return listConUNIAnesthesiaFeeSchedule;
        }

        public bool deleteConUNIAnesthesiaFeeSchedule(long ID, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ID)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_ConUNIAnesthesiaFeeScheduleDelete", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_ConOptAnesthesiaFeeScheduleDelete", CommandType.StoredProcedure, parameters);
        }

        public bool updateConUNIAnesthesiaFeeSchedule(TableConUNIAnesthesiaFeeSchedule ConUNIAnesthesiaFeeSchedule, string username, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@ID", ConUNIAnesthesiaFeeSchedule.ID),
			    new SqlParameter("@FromDate",ConUNIAnesthesiaFeeSchedule.FromDate),
			    new SqlParameter("@ToDate", ConUNIAnesthesiaFeeSchedule.ToDate),
			    new SqlParameter("@ProcedureCode", ConUNIAnesthesiaFeeSchedule.ProcedureCode),
			    new SqlParameter("@Unit", ConUNIAnesthesiaFeeSchedule.Unit),
			    new SqlParameter("@ParAllow", ConUNIAnesthesiaFeeSchedule.ParAllow),
			    new SqlParameter("@Locality",ConUNIAnesthesiaFeeSchedule.Locality),
			    new SqlParameter("@IPA_NAME",ConUNIAnesthesiaFeeSchedule.IPA_NAME),
			    new SqlParameter("@PlanName",ConUNIAnesthesiaFeeSchedule.PlanName)
                ,new SqlParameter("@ModifiedBy", username)
                ,new SqlParameter("@ModifiedOn", DateTime.Now)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_ConUNIAnesthesiaFeeScheduleUpdate", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_ConOptAnesthesiaFeeScheduleUpdate", CommandType.StoredProcedure, parameters);
        }

        public bool insertConUNIAnesthesiaFeeSchedule(TableConUNIAnesthesiaFeeSchedule ConUNIAnesthesiaFeeSchedule, int DbID)
        {
            SqlParameter[] parameters = new SqlParameter[]
		    {
			    new SqlParameter("@FromDate",ConUNIAnesthesiaFeeSchedule.FromDate),
			    new SqlParameter("@ToDate", ConUNIAnesthesiaFeeSchedule.ToDate),
			    new SqlParameter("@ProcedureCode", ConUNIAnesthesiaFeeSchedule.ProcedureCode),
			    new SqlParameter("@Unit", ConUNIAnesthesiaFeeSchedule.Unit),
			    new SqlParameter("@ParAllow", ConUNIAnesthesiaFeeSchedule.ParAllow),
			    new SqlParameter("@Locality",ConUNIAnesthesiaFeeSchedule.Locality),
			    new SqlParameter("@IPA_NAME",ConUNIAnesthesiaFeeSchedule.IPA_NAME),
			    new SqlParameter("@PlanName",ConUNIAnesthesiaFeeSchedule.PlanName)
		    };

            if (DbID == (int)_Contestation.FREEDOM)
                return FreedomDatabase.ExecuteNonQuery("usp_tbl_ConUNIAnesthesiaFeeScheduleInsert", CommandType.StoredProcedure, parameters);
            else
                return OptimumDatabase.ExecuteNonQuery("usp_tbl_ConOptAnesthesiaFeeScheduleInsert", CommandType.StoredProcedure, parameters);
        }

        #endregion

        #endregion

        #endregion

    }
}

