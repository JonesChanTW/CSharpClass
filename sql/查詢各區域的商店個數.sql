---查詢各區域的商店個數
Select g.REGION_NAME, count(si.store_name) as TotslDtore from STORE_INFORMATION as si left join GEOGRAPHY as g on g.GEOGRAPHY_ID = si.FK_GEOGRAPHY_ID group by g.REGION_NAME 