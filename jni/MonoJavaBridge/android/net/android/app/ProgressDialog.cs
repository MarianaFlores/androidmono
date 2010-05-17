namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ProgressDialog : android.app.AlertDialog
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ProgressDialog() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.ProgressDialog), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.ProgressDialog(@__env); 
			} 
		} 
		protected ProgressDialog(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate700; 
		protected override void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				@__env.CallVoidMethod(this, _onCreate700, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ProgressDialog.staticClass, _onCreate700, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStart701; 
		public virtual new void onStart() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				@__env.CallVoidMethod(this, _onStart701); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ProgressDialog.staticClass, _onStart701); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onStop702; 
		protected override void onStop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				@__env.CallVoidMethod(this, _onStop702); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ProgressDialog.staticClass, _onStop702); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgress703; 
		public virtual void setProgress(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				@__env.CallVoidMethod(this, _setProgress703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ProgressDialog.staticClass, _setProgress703, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSecondaryProgress704; 
		public virtual void setSecondaryProgress(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				@__env.CallVoidMethod(this, _setSecondaryProgress704, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ProgressDialog.staticClass, _setSecondaryProgress704, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show705; 
		public static android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.ProgressDialog>(@__env, @__env.CallStaticObjectMethodPtr(android.app.ProgressDialog.staticClass, _show705, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show706; 
		public static android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.ProgressDialog>(@__env, @__env.CallStaticObjectMethodPtr(android.app.ProgressDialog.staticClass, _show706, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show707; 
		public static android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3, bool arg4, android.content.DialogInterface_OnCancelListener arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.ProgressDialog>(@__env, @__env.CallStaticObjectMethodPtr(android.app.ProgressDialog.staticClass, _show707, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg5))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _show708; 
		public static android.app.ProgressDialog show(android.content.Context arg0, java.lang.CharSequence arg1, java.lang.CharSequence arg2, bool arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.app.ProgressDialog>(@__env, @__env.CallStaticObjectMethodPtr(android.app.ProgressDialog.staticClass, _show708, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMessage709; 
		public override void setMessage(java.lang.CharSequence arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				@__env.CallVoidMethod(this, _setMessage709, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ProgressDialog.staticClass, _setMessage709, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getProgress710; 
		public virtual int getProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				return @__env.CallIntMethod(this, _getProgress710); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.ProgressDialog.staticClass, _getProgress710); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSecondaryProgress711; 
		public virtual int getSecondaryProgress() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				return @__env.CallIntMethod(this, _getSecondaryProgress711); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.ProgressDialog.staticClass, _getSecondaryProgress711); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMax712; 
		public virtual int getMax() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				return @__env.CallIntMethod(this, _getMax712); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.app.ProgressDialog.staticClass, _getMax712); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMax713; 
		public virtual void setMax(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				@__env.CallVoidMethod(this, _setMax713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ProgressDialog.staticClass, _setMax713, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _incrementProgressBy714; 
		public virtual void incrementProgressBy(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				@__env.CallVoidMethod(this, _incrementProgressBy714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ProgressDialog.staticClass, _incrementProgressBy714, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _incrementSecondaryProgressBy715; 
		public virtual void incrementSecondaryProgressBy(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				@__env.CallVoidMethod(this, _incrementSecondaryProgressBy715, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ProgressDialog.staticClass, _incrementSecondaryProgressBy715, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgressDrawable716; 
		public virtual void setProgressDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				@__env.CallVoidMethod(this, _setProgressDrawable716, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ProgressDialog.staticClass, _setProgressDrawable716, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIndeterminateDrawable717; 
		public virtual void setIndeterminateDrawable(android.graphics.drawable.Drawable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				@__env.CallVoidMethod(this, _setIndeterminateDrawable717, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ProgressDialog.staticClass, _setIndeterminateDrawable717, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setIndeterminate718; 
		public virtual void setIndeterminate(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				@__env.CallVoidMethod(this, _setIndeterminate718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ProgressDialog.staticClass, _setIndeterminate718, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isIndeterminate719; 
		public virtual bool isIndeterminate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				return @__env.CallBooleanMethod(this, _isIndeterminate719); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.app.ProgressDialog.staticClass, _isIndeterminate719); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setProgressStyle720; 
		public virtual void setProgressStyle(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.ProgressDialog)) 
				@__env.CallVoidMethod(this, _setProgressStyle720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.ProgressDialog.staticClass, _setProgressStyle720, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProgressDialog721; 
		public ProgressDialog(android.content.Context arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.ProgressDialog.staticClass, _ProgressDialog721, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ProgressDialog722; 
		public ProgressDialog(android.content.Context arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.ProgressDialog.staticClass, _ProgressDialog722, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		public static int STYLE_SPINNER
		{ 
			get 
			{ 
				return 0; 
			} 
		} 
		public static int STYLE_HORIZONTAL
		{ 
			get 
			{ 
				return 1; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.ProgressDialog.staticClass = @__class; 
			global::android.app.ProgressDialog._onCreate700 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.ProgressDialog._onStart701 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "onStart", "()V"); 
			global::android.app.ProgressDialog._onStop702 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "onStop", "()V"); 
			global::android.app.ProgressDialog._setProgress703 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setProgress", "(I)V"); 
			global::android.app.ProgressDialog._setSecondaryProgress704 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setSecondaryProgress", "(I)V"); 
			global::android.app.ProgressDialog._show705 = @__env.GetStaticMethodID(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;)Landroid/app/ProgressDialog;"); 
			global::android.app.ProgressDialog._show706 = @__env.GetStaticMethodID(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZ)Landroid/app/ProgressDialog;"); 
			global::android.app.ProgressDialog._show707 = @__env.GetStaticMethodID(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;ZZLandroid/content/DialogInterface$OnCancelListener;)Landroid/app/ProgressDialog;"); 
			global::android.app.ProgressDialog._show708 = @__env.GetStaticMethodID(global::android.app.ProgressDialog.staticClass, "show", "(Landroid/content/Context;Ljava/lang/CharSequence;Ljava/lang/CharSequence;Z)Landroid/app/ProgressDialog;"); 
			global::android.app.ProgressDialog._setMessage709 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setMessage", "(Ljava/lang/CharSequence;)V"); 
			global::android.app.ProgressDialog._getProgress710 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "getProgress", "()I"); 
			global::android.app.ProgressDialog._getSecondaryProgress711 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "getSecondaryProgress", "()I"); 
			global::android.app.ProgressDialog._getMax712 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "getMax", "()I"); 
			global::android.app.ProgressDialog._setMax713 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setMax", "(I)V"); 
			global::android.app.ProgressDialog._incrementProgressBy714 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "incrementProgressBy", "(I)V"); 
			global::android.app.ProgressDialog._incrementSecondaryProgressBy715 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "incrementSecondaryProgressBy", "(I)V"); 
			global::android.app.ProgressDialog._setProgressDrawable716 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setProgressDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.app.ProgressDialog._setIndeterminateDrawable717 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setIndeterminateDrawable", "(Landroid/graphics/drawable/Drawable;)V"); 
			global::android.app.ProgressDialog._setIndeterminate718 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setIndeterminate", "(Z)V"); 
			global::android.app.ProgressDialog._isIndeterminate719 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "isIndeterminate", "()Z"); 
			global::android.app.ProgressDialog._setProgressStyle720 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "setProgressStyle", "(I)V"); 
			global::android.app.ProgressDialog._ProgressDialog721 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;)V"); 
			global::android.app.ProgressDialog._ProgressDialog722 = @__env.GetMethodID(global::android.app.ProgressDialog.staticClass, "<init>", "(Landroid/content/Context;I)V"); 
		} 
	} 
} 