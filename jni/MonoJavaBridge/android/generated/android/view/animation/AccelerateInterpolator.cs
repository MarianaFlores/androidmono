namespace android.view.animation
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccelerateInterpolator : java.lang.Object, Interpolator
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccelerateInterpolator()
		{
			InitJNI();
		}
		protected AccelerateInterpolator(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getInterpolation9891;
		public virtual float getInterpolation(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.view.animation.AccelerateInterpolator._getInterpolation9891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.view.animation.AccelerateInterpolator.staticClass, global::android.view.animation.AccelerateInterpolator._getInterpolation9891, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AccelerateInterpolator9892;
		public AccelerateInterpolator()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AccelerateInterpolator.staticClass, global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator9892);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AccelerateInterpolator9893;
		public AccelerateInterpolator(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AccelerateInterpolator.staticClass, global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator9893, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AccelerateInterpolator9894;
		public AccelerateInterpolator(android.content.Context arg0, android.util.AttributeSet arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.view.animation.AccelerateInterpolator.staticClass, global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator9894, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.view.animation.AccelerateInterpolator.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/view/animation/AccelerateInterpolator"));
			global::android.view.animation.AccelerateInterpolator._getInterpolation9891 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateInterpolator.staticClass, "getInterpolation", "(F)F");
			global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator9892 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateInterpolator.staticClass, "<init>", "()V");
			global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator9893 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateInterpolator.staticClass, "<init>", "(F)V");
			global::android.view.animation.AccelerateInterpolator._AccelerateInterpolator9894 = @__env.GetMethodIDNoThrow(global::android.view.animation.AccelerateInterpolator.staticClass, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
		}
	}
}
