package crc64cacd98752360d8a4;


public class finalization
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onRestart:()V:GetOnRestartHandler\n" +
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("CompEat_CuppyBreak_Initial.Resources.finalization, CompEat_CuppyBreak_Initial", finalization.class, __md_methods);
	}


	public finalization ()
	{
		super ();
		if (getClass () == finalization.class) {
			mono.android.TypeManager.Activate ("CompEat_CuppyBreak_Initial.Resources.finalization, CompEat_CuppyBreak_Initial", "", this, new java.lang.Object[] {  });
		}
	}


	public void onRestart ()
	{
		n_onRestart ();
	}

	private native void n_onRestart ();


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
