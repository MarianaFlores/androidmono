namespace android.graphics
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class LayerRasterizer : android.graphics.Rasterizer
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static LayerRasterizer()
		{
			InitJNI();
		}
		protected LayerRasterizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addLayer3330;
		public virtual void addLayer(android.graphics.Paint arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.LayerRasterizer._addLayer3330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.LayerRasterizer.staticClass, global::android.graphics.LayerRasterizer._addLayer3330, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addLayer3331;
		public virtual void addLayer(android.graphics.Paint arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.graphics.LayerRasterizer._addLayer3331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.graphics.LayerRasterizer.staticClass, global::android.graphics.LayerRasterizer._addLayer3331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _LayerRasterizer3332;
		public LayerRasterizer()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.graphics.LayerRasterizer.staticClass, global::android.graphics.LayerRasterizer._LayerRasterizer3332);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.graphics.LayerRasterizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/graphics/LayerRasterizer"));
			global::android.graphics.LayerRasterizer._addLayer3330 = @__env.GetMethodIDNoThrow(global::android.graphics.LayerRasterizer.staticClass, "addLayer", "(Landroid/graphics/Paint;FF)V");
			global::android.graphics.LayerRasterizer._addLayer3331 = @__env.GetMethodIDNoThrow(global::android.graphics.LayerRasterizer.staticClass, "addLayer", "(Landroid/graphics/Paint;)V");
			global::android.graphics.LayerRasterizer._LayerRasterizer3332 = @__env.GetMethodIDNoThrow(global::android.graphics.LayerRasterizer.staticClass, "<init>", "()V");
		}
	}
}
