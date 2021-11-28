# WeatherForecastForXML
##火箭隊爬蟲作業-氣象
參考API：https://opendata.cwb.gov.tw/fileapi/v1/opendataapi/F-A0012-001?Authorization=CWB-BC2E6A08-130F-4DCA-B26C-8E5ADF09F133&downloadType=WEB&format=XML<br>
參考輸出畫面：https://www.cwb.gov.tw/V8/C/M/NSea.html<br>

open Data<br>
https://opendata.cwb.gov.tw/dataset/forecast/F-A0012-001<br>

這邊要注意xml有前置詞問題，需要新增到XmlNamespaceManager，不然無法使用Xpath<br>
參考資料：https://docs.microsoft.com/zh-tw/dotnet/api/system.xml.xmlnamespacemanager?view=net-6.0<br>

Xpath參考資料：https://docs.microsoft.com/zh-tw/previous-versions/dotnet/netframework-3.5/ms256086(v=vs.90)<br>

圖片顯示需要記得補0，才是正確的名稱。<br>

由HomeController.cs控制資料，Home/Index.cshtml顯示畫面。<br>
要改版型由Shared/_Layout.cshtml修正<br>


