namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Html : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Html()
		{
			InitJNI();
		}
		protected Html(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.Html.ImageGetter_))]
		public interface ImageGetter  : global::MonoJavaBridge.IJavaObject 
		{
			global::android.graphics.drawable.Drawable getDrawable(java.lang.String arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.Html.ImageGetter))]
		public sealed partial class ImageGetter_ : java.lang.Object, ImageGetter
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static ImageGetter_()
			{
				InitJNI();
			}
			internal ImageGetter_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _getDrawable7686;
			 global::android.graphics.drawable.Drawable android.text.Html.ImageGetter.getDrawable(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.text.Html.ImageGetter_._getDrawable7686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.text.Html.ImageGetter_.staticClass, global::android.text.Html.ImageGetter_._getDrawable7686, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.graphics.drawable.Drawable;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.Html.ImageGetter_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Html$ImageGetter"));
				global::android.text.Html.ImageGetter_._getDrawable7686 = @__env.GetMethodIDNoThrow(global::android.text.Html.ImageGetter_.staticClass, "getDrawable", "(Ljava/lang/String;)Landroid/graphics/drawable/Drawable;");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.text.Html.TagHandler_))]
		public interface TagHandler  : global::MonoJavaBridge.IJavaObject 
		{
			void handleTag(bool arg0, java.lang.String arg1, android.text.Editable arg2, org.xml.sax.XMLReader arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.text.Html.TagHandler))]
		public sealed partial class TagHandler_ : java.lang.Object, TagHandler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static TagHandler_()
			{
				InitJNI();
			}
			internal TagHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _handleTag7687;
			 void android.text.Html.TagHandler.handleTag(bool arg0, java.lang.String arg1, android.text.Editable arg2, org.xml.sax.XMLReader arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.text.Html.TagHandler_._handleTag7687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.text.Html.TagHandler_.staticClass, global::android.text.Html.TagHandler_._handleTag7687, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.text.Html.TagHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Html$TagHandler"));
				global::android.text.Html.TagHandler_._handleTag7687 = @__env.GetMethodIDNoThrow(global::android.text.Html.TagHandler_.staticClass, "handleTag", "(ZLjava/lang/String;Landroid/text/Editable;Lorg/xml/sax/XMLReader;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _fromHtml7688;
		public static global::android.text.Spanned fromHtml(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Spanned>(@__env.CallStaticObjectMethod(android.text.Html.staticClass, global::android.text.Html._fromHtml7688, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.text.Spanned;
		}
		internal static global::MonoJavaBridge.MethodId _fromHtml7689;
		public static global::android.text.Spanned fromHtml(java.lang.String arg0, android.text.Html.ImageGetter arg1, android.text.Html.TagHandler arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.text.Spanned>(@__env.CallStaticObjectMethod(android.text.Html.staticClass, global::android.text.Html._fromHtml7689, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.text.Spanned;
		}
		internal static global::MonoJavaBridge.MethodId _toHtml7690;
		public static global::java.lang.String toHtml(android.text.Spanned arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.Html.staticClass, global::android.text.Html._toHtml7690, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.Html.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/Html"));
			global::android.text.Html._fromHtml7688 = @__env.GetStaticMethodIDNoThrow(global::android.text.Html.staticClass, "fromHtml", "(Ljava/lang/String;)Landroid/text/Spanned;");
			global::android.text.Html._fromHtml7689 = @__env.GetStaticMethodIDNoThrow(global::android.text.Html.staticClass, "fromHtml", "(Ljava/lang/String;Landroid/text/Html$ImageGetter;Landroid/text/Html$TagHandler;)Landroid/text/Spanned;");
			global::android.text.Html._toHtml7690 = @__env.GetStaticMethodIDNoThrow(global::android.text.Html.staticClass, "toHtml", "(Landroid/text/Spanned;)Ljava/lang/String;");
		}
	}
}
