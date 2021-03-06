namespace android.accounts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AccountAuthenticatorActivity : android.app.Activity
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AccountAuthenticatorActivity()
		{
			InitJNI();
		}
		protected AccountAuthenticatorActivity(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onCreate63;
		protected override void onCreate(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorActivity._onCreate63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorActivity.staticClass, global::android.accounts.AccountAuthenticatorActivity._onCreate63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setAccountAuthenticatorResult64;
		public virtual void setAccountAuthenticatorResult(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorActivity._setAccountAuthenticatorResult64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorActivity.staticClass, global::android.accounts.AccountAuthenticatorActivity._setAccountAuthenticatorResult64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _finish65;
		public override void finish() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorActivity._finish65);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.accounts.AccountAuthenticatorActivity.staticClass, global::android.accounts.AccountAuthenticatorActivity._finish65);
		}
		internal static global::MonoJavaBridge.MethodId _AccountAuthenticatorActivity66;
		public AccountAuthenticatorActivity()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.accounts.AccountAuthenticatorActivity.staticClass, global::android.accounts.AccountAuthenticatorActivity._AccountAuthenticatorActivity66);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.accounts.AccountAuthenticatorActivity.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/accounts/AccountAuthenticatorActivity"));
			global::android.accounts.AccountAuthenticatorActivity._onCreate63 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V");
			global::android.accounts.AccountAuthenticatorActivity._setAccountAuthenticatorResult64 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorActivity.staticClass, "setAccountAuthenticatorResult", "(Landroid/os/Bundle;)V");
			global::android.accounts.AccountAuthenticatorActivity._finish65 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorActivity.staticClass, "finish", "()V");
			global::android.accounts.AccountAuthenticatorActivity._AccountAuthenticatorActivity66 = @__env.GetMethodIDNoThrow(global::android.accounts.AccountAuthenticatorActivity.staticClass, "<init>", "()V");
		}
	}
}
