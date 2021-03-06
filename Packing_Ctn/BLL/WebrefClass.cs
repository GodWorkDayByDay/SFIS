﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Packing_Ctn
{    
    public class refWebtWoInfo
    {
        private static WebServices.tWoInfo.tWoInfo instance;

        public static WebServices.tWoInfo.tWoInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tWoInfo.tWoInfo();
                return instance;
            }
        }
        static refWebtWoInfo()
        {
            instance = new WebServices.tWoInfo.tWoInfo();
        }
    }
    public class refWebtWoBomInfo
    {
        private static WebServices.tWoBomInfo.tWoBomInfo instance;

        public static WebServices.tWoBomInfo.tWoBomInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tWoBomInfo.tWoBomInfo();
                return instance;
            }
        }
        static refWebtWoBomInfo()
        {
            instance = new WebServices.tWoBomInfo.tWoBomInfo();
        }
    }
    public class refWebtUserInfo
    {
        private static WebServices.tUserInfo.tUserInfo instance;

        public static WebServices.tUserInfo.tUserInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tUserInfo.tUserInfo();
                return instance;
            }
        }
        static refWebtUserInfo()
        {
            instance = new WebServices.tUserInfo.tUserInfo();
        }
    }

    public class refWebtProduct
    {
        private static WebServices.tProduct.tProduct instance;
        public static WebServices.tProduct.tProduct Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tProduct.tProduct();
                return instance;
            }
        }
        static refWebtProduct()
        {
            instance = new WebServices.tProduct.tProduct();
        }
    }

    public class refWebtLineInfo
    {
        private static WebServices.tLineInfo.tLineInfo instance;

        public static WebServices.tLineInfo.tLineInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tLineInfo.tLineInfo();
                return instance;
            }
        }
        static refWebtLineInfo()
        {
            instance = new WebServices.tLineInfo.tLineInfo();
        }
    }

    public class refWebtCraftInfo
    {
        private static WebServices.tCraftInfo.tCraftInfo instance;

        public static WebServices.tCraftInfo.tCraftInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tCraftInfo.tCraftInfo();
                return instance;
            }
        }
        static refWebtCraftInfo()
        {
            instance = new WebServices.tCraftInfo.tCraftInfo();
        }
    }
    public class refWebRecodeSystemLog
    {
        private static WebServices.RecodeSystemLog.RecodeSystemLog instance;

        public static WebServices.RecodeSystemLog.RecodeSystemLog Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.RecodeSystemLog.RecodeSystemLog();
                return instance;
            }
        }
        static refWebRecodeSystemLog()
        {
            instance = new WebServices.RecodeSystemLog.RecodeSystemLog();
        }
    }
    public class refWebExecuteSqlCmd
    {

        private static WebServices.ExecuteSqlCmd.ExecuteSqlCmd instance;

        public static WebServices.ExecuteSqlCmd.ExecuteSqlCmd Instance
        {
            get
            {

                if (instance == null)
                    instance = new WebServices.ExecuteSqlCmd.ExecuteSqlCmd();
                return instance;
            }
        }
        static refWebExecuteSqlCmd()
        {
            instance = new WebServices.ExecuteSqlCmd.ExecuteSqlCmd();
        }
    }
    public class refWebExcelToDb
    {
        private static WebServices.ExcelToDb.ExcelToDb instance;

        public static WebServices.ExcelToDb.ExcelToDb Instance
        {
            get
            {

                if (instance == null)
                    instance = new WebServices.ExcelToDb.ExcelToDb();
                return instance;
            }
        }
        static refWebExcelToDb()
        {
            instance = new WebServices.ExcelToDb.ExcelToDb();
        }
    }
    public class refWebtPartMap
    {
        private static WebServices.tPartMap.tPartMap instance;

        public static WebServices.tPartMap.tPartMap Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tPartMap.tPartMap();
                return instance;
            }
        }
        static refWebtPartMap()
        {
            instance = new WebServices.tPartMap.tPartMap();
        }
    }
    public class refWebtRouteInfo
    {
        private static WebServices.tRouteInfo.tRouteInfo instance;

        public static WebServices.tRouteInfo.tRouteInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tRouteInfo.tRouteInfo();
                return instance;
            }
        }
        static refWebtRouteInfo()
        {
            instance = new WebServices.tRouteInfo.tRouteInfo();
        }
    }
    public class refWebtVenderCode
    {
        private static WebServices.tVenderCode.tVenderCode instance;

        public static WebServices.tVenderCode.tVenderCode Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tVenderCode.tVenderCode();
                return instance;
            }
        }
        static refWebtVenderCode()
        {
            instance = new WebServices.tVenderCode.tVenderCode();
        }
    }
    public class refWebtStorehouseManage
    {
        private static WebServices.tStorehouseManage.tStorehouseManage instance;

        public static WebServices.tStorehouseManage.tStorehouseManage Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tStorehouseManage.tStorehouseManage();
                return instance;
            }
        }
        static refWebtStorehouseManage()
        {
            instance = new WebServices.tStorehouseManage.tStorehouseManage();
        }
    }
    public class refWebtPartStorehousehad
    {
        private static WebServices.tPartStorehousehad.tPartStorehousehad instance;

        public static WebServices.tPartStorehousehad.tPartStorehousehad Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tPartStorehousehad.tPartStorehousehad();
                return instance;
            }
        }
        static refWebtPartStorehousehad()
        {
            instance = new WebServices.tPartStorehousehad.tPartStorehousehad();
        }
    }
    public class refWebVenderInfo
    {
        private static WebServices.tVenderInfo.tVenderInfo instance;

        public static WebServices.tVenderInfo.tVenderInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tVenderInfo.tVenderInfo();
                return instance;
            }
        }
        static refWebVenderInfo()
        {
            instance = new WebServices.tVenderInfo.tVenderInfo();
        }
    }
    public class refWebSmtKpMaster
    {
        private static WebServices.tSmtKpMaster.tSmtKpMaster instance;

        public static WebServices.tSmtKpMaster.tSmtKpMaster Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tSmtKpMaster.tSmtKpMaster();
                return instance;
            }
        }
        static refWebSmtKpMaster()
        {
            instance = new WebServices.tSmtKpMaster.tSmtKpMaster();
        }
    }
    public class refWebSmtIO
    {
        private static WebServices.tSmtIO.tSmtIO instance;

        public static WebServices.tSmtIO.tSmtIO Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tSmtIO.tSmtIO();
                return instance;
            }
        }
        static refWebSmtIO()
        {
            instance = new WebServices.tSmtIO.tSmtIO();
        }
    }
    public class refWebtMaterialPreparation
    {
        private static WebServices.tMaterialPreparation.tMaterialPreparation instance;

        public static WebServices.tMaterialPreparation.tMaterialPreparation Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tMaterialPreparation.tMaterialPreparation();
                return instance;
            }
        }
        static refWebtMaterialPreparation()
        {
            instance = new WebServices.tMaterialPreparation.tMaterialPreparation();
        }
    }
    public class refWebtGetServersTime
    {
        private static WebServices.tGetServersTime.tGetServersTime instance;

        public static WebServices.tGetServersTime.tGetServersTime Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tGetServersTime.tGetServersTime();
                return instance;
            }
        }
        static refWebtGetServersTime()
        {
            instance = new WebServices.tGetServersTime.tGetServersTime();
        }
    }

    public class refWebtErrorCode
    {
        private static WebServices.tEerrorCode.tEerrorCode instance;

        public static WebServices.tEerrorCode.tEerrorCode Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tEerrorCode.tEerrorCode();
                return instance;
            }
        }
        static refWebtErrorCode()
        {
            instance = new WebServices.tEerrorCode.tEerrorCode();
        }
    }
    public class refWebtReasonCode
    {
        private static WebServices.tReasonCode.tReasonCode instance;

        public static WebServices.tReasonCode.tReasonCode Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tReasonCode.tReasonCode();
                return instance;
            }
        }
        static refWebtReasonCode()
        {
            instance = new WebServices.tReasonCode.tReasonCode();
        }
    }
    public class refWebtPackParameters
    {
        private static WebServices.tPackParameters.tPackParameters instance;

        public static WebServices.tPackParameters.tPackParameters Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tPackParameters.tPackParameters();
                return instance;
            }
        }
        static refWebtPackParameters()
        {
            instance = new WebServices.tPackParameters.tPackParameters();
        }
    }

    public class refWebtKeyPart
    {
        private static WebServices.tKeyPart.tKeyPart instance;

        public static WebServices.tKeyPart.tKeyPart Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tKeyPart.tKeyPart();
                return instance;
            }
        }
        static refWebtKeyPart()
        {
            instance = new WebServices.tKeyPart.tKeyPart();
        }
    }

    public class refWebtBomKeyPart
    {
        private static WebServices.tBomKeyPart.tBomKeyPart instance;

        public static WebServices.tBomKeyPart.tBomKeyPart Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tBomKeyPart.tBomKeyPart();
                return instance;
            }
        }
        static refWebtBomKeyPart()
        {
            instance = new WebServices.tBomKeyPart.tBomKeyPart();
        }
    }

    public class refWebtPartKeyParts
    {
        private static WebServices.tPartKeyParts.tPartKeyParts instance;

        public static WebServices.tPartKeyParts.tPartKeyParts Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tPartKeyParts.tPartKeyParts();
                return instance;
            }
        }
        static refWebtPartKeyParts()
        {
            instance = new WebServices.tPartKeyParts.tPartKeyParts();
        }
    }

    public class refWebtWipTracking
    {
        private static WebServices.tWipTracking.tWipTracking instance;

        public static WebServices.tWipTracking.tWipTracking Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tWipTracking.tWipTracking();
                return instance;
            }
        }
        static refWebtWipTracking()
        {
            instance = new WebServices.tWipTracking.tWipTracking();
        }
    }

    public class refWebtWipDetail
    {
        private static WebServices.tWipDetail.tWipDetail instance;

        public static WebServices.tWipDetail.tWipDetail Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tWipDetail.tWipDetail();
                return instance;
            }
        }
        static refWebtWipDetail()
        {
            instance = new WebServices.tWipDetail.tWipDetail();
        }
    }

    public class refWebtWipKeyPart
    {
        private static WebServices.tWipKeyPart.tWipKeyPart instance;

        public static WebServices.tWipKeyPart.tWipKeyPart Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tWipKeyPart.tWipKeyPart();
                return instance;
            }
        }
        static refWebtWipKeyPart()
        {
            instance = new WebServices.tWipKeyPart.tWipKeyPart();
        }
    }


    public class refWebtTargetPlan
    {
        private static WebServices.tTargetPlan.tTargetPlan instance;

        public static WebServices.tTargetPlan.tTargetPlan Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tTargetPlan.tTargetPlan();
                return instance;
            }
        }
        static refWebtTargetPlan()
        {
            instance = new WebServices.tTargetPlan.tTargetPlan();
        }
    }
    public class refWebProPublicStoredproc
    {
        private static WebServices.tPublicStoredproc.tPublicStoredproc instance;
        public static WebServices.tPublicStoredproc.tPublicStoredproc Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tPublicStoredproc.tPublicStoredproc();
                return instance;
            }
        }
        static refWebProPublicStoredproc()
        {
            instance = new WebServices.tPublicStoredproc.tPublicStoredproc();
        }
    }
    public class refWebRepairInfo
    {
        private static WebServices.tRepairInfo.tRepairInfo instance;
        public static WebServices.tRepairInfo.tRepairInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tRepairInfo.tRepairInfo();
                return instance;
            }
        }
        static refWebRepairInfo()
        {
            instance = new WebServices.tRepairInfo.tRepairInfo();
        }
    }
    public class tCheckDataTestAte
    {
        private static WebServices.tCheckDataTestAte.tCheckDataTestAte instance;
        public static WebServices.tCheckDataTestAte.tCheckDataTestAte Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tCheckDataTestAte.tCheckDataTestAte();
                return instance;
            }
        }
        static tCheckDataTestAte()
        {
            instance = new WebServices.tCheckDataTestAte.tCheckDataTestAte();
        }
    }

    public class refWebtPalletInfo
    {
        private static WebServices.tPalletInfo.tPalletInfo instance;
        public static WebServices.tPalletInfo.tPalletInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tPalletInfo.tPalletInfo();
                return instance;
            }
        }
        static refWebtPalletInfo()
        {
            instance = new WebServices.tPalletInfo.tPalletInfo();
        }
    }
    public class refWebtWarehouseWipTracking
    {
        private static WebServices.tWarehouseWipTracking.tWarehouseWipTracking instance;
        public static WebServices.tWarehouseWipTracking.tWarehouseWipTracking Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tWarehouseWipTracking.tWarehouseWipTracking();
                return instance;
            }
        }
        static refWebtWarehouseWipTracking()
        {
            instance = new WebServices.tWarehouseWipTracking.tWarehouseWipTracking();
        }
    }

    public class refWebSapConnector
    {
        private static WebServices.SapConnector.SapConnector instance;

        public static WebServices.SapConnector.SapConnector Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.SapConnector.SapConnector();
                return instance;
            }
        }
        static refWebSapConnector()
        {
            instance = new WebServices.SapConnector.SapConnector();
        }
    }
    public class refWebtStationRec
    {
        private static WebServices.tStationrecount.tStationrecount instance;

        public static WebServices.tStationrecount.tStationrecount Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tStationrecount.tStationrecount();
                return instance;
            }
        }
        static refWebtStationRec()
        {
            instance = new WebServices.tStationrecount.tStationrecount();
        }
    }
    public class refWebtCustomer
    {
        private static WebServices.tCustomer.tCustomer instance;

        public static WebServices.tCustomer.tCustomer Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tCustomer.tCustomer();
                return instance;
            }
        }
        static refWebtCustomer()
        {
            instance = new WebServices.tCustomer.tCustomer();
        }
    }
    public class refWebtReworkDetailInfo
    {
        private static WebServices.tReworkDetailInfo.tReworkDetailInfo instance;

        public static WebServices.tReworkDetailInfo.tReworkDetailInfo Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tReworkDetailInfo.tReworkDetailInfo();
                return instance;
            }
        }
        static refWebtReworkDetailInfo()
        {
            instance = new WebServices.tReworkDetailInfo.tReworkDetailInfo();
        }
    }

    public class refwebtEditing
    {
        private static WebServices.tEditing.tEditing instance;

        public static WebServices.tEditing.tEditing Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tEditing.tEditing();
                return instance;
            }
        }
        static refwebtEditing()
        {
            instance = new WebServices.tEditing.tEditing();
        }
    }

    public class refwebtMaterialsReceive
    {
        private static WebServices.tMaterialsReceive.tMaterialsReceive instance;

        public static WebServices.tMaterialsReceive.tMaterialsReceive Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tMaterialsReceive.tMaterialsReceive();
                return instance;
            }

        }
        static refwebtMaterialsReceive()
        {
            instance = new WebServices.tMaterialsReceive.tMaterialsReceive();
        }

    }

    public class refWebCheck_Version
    {
        private static WebServices.Check_Version.Check_Version instance;

        public static WebServices.Check_Version.Check_Version Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.Check_Version.Check_Version();
                return instance;
            }
        }
        static refWebCheck_Version()
        {
            instance = new WebServices.Check_Version.Check_Version();
        }
    }

    public class refWebtB_SnRule_PartNumber
    {
        private static WebServices.tB_SnRule_PartNumber.tB_SnRule_PartNumber instance;

        public static WebServices.tB_SnRule_PartNumber.tB_SnRule_PartNumber Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tB_SnRule_PartNumber.tB_SnRule_PartNumber();
                return instance;
            }
        }
        static refWebtB_SnRule_PartNumber()
        {
            instance = new WebServices.tB_SnRule_PartNumber.tB_SnRule_PartNumber();
        }
    }

    public class refWebtB_SnRule_wo
    {
        private static WebServices.tB_SnRule_WO.tB_SNRULE_WO instance;

        public static WebServices.tB_SnRule_WO.tB_SNRULE_WO Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tB_SnRule_WO.tB_SNRULE_WO();
                return instance;
            }
        }
        static refWebtB_SnRule_wo()
        {
            instance = new WebServices.tB_SnRule_WO.tB_SNRULE_WO();
        }
    }
    public class refWebt_Check_Timeout
    {
        private static WebServices.t_Check_Timeout.t_Check_Timeout instance;

        public static WebServices.t_Check_Timeout.t_Check_Timeout Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.t_Check_Timeout.t_Check_Timeout();
                return instance;
            }
        }
        static refWebt_Check_Timeout()
        {
            instance = new WebServices.t_Check_Timeout.t_Check_Timeout();
        }
    }
    public class refWebtPublicStoredproc
    {
        private static WebServices.tPublicStoredproc.tPublicStoredproc instance;
        public static WebServices.tPublicStoredproc.tPublicStoredproc Instance
        {
            get
            {
                if (instance == null)
                    instance = new WebServices.tPublicStoredproc.tPublicStoredproc();
                return instance;
            }
        }
        static refWebtPublicStoredproc()
        {
            instance = new WebServices.tPublicStoredproc.tPublicStoredproc();
        }
    }
 
}
