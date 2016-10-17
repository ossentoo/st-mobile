using MvvmCross.Core.ViewModels;
using MvvmCross.Platform.IoC;
using SpaceLinx.Training.Core.ViewModels;

namespace SpaceLinx.Training.Core
{
    public class App : MvxApplication
    {
        //Create two static doubles that will be used to size elements
        public static double ScreenWidth;
        public static double ScreenHeight;

        public override void Initialize()
        {
            CreatableTypes()
                .EndingWith("Service")
                .AsInterfaces()
                .RegisterAsLazySingleton();

            RegisterAppStart<ListViewModel>();
        }    
    }
}
