using Android.Runtime;
using Java.Lang;
using Microsoft.Extensions.DependencyInjection;

namespace Com.AICaptionLibrary
{
    [Register("com/aicaptionlibrary/CalculatorService2")]
    public class CalculatorService : Java.Lang.Object
    {
        private readonly ICalculator _calculator;
        static IntPtr class_ref = JNIEnv.FindClass("com/aicaptionlibrary/CalculatorService");

        public CalculatorService() : base(
            JNIEnv.StartCreateInstance("com/aicaptionlibrary/CalculatorService", "()V"),
            JniHandleOwnership.TransferLocalRef)
        {
            JNIEnv.FinishCreateInstance(Handle, "()V");
            
            var services = new ServiceCollection();
            services.AddSingleton<ICalculator, Calculator>();
            var serviceProvider = services.BuildServiceProvider();
            _calculator = serviceProvider.GetService<ICalculator>();
        }

        [Register("add", "(II)I", "GetAdd")]
        public int Add(int a, int b)
        {
            return _calculator.Add(a, b);
        }

        [Register("getMessage", "()Ljava/lang/String;", "GetMessage")]
        public string GetMessage()
        {
            return _calculator.GetMessage();
        }
    }
}