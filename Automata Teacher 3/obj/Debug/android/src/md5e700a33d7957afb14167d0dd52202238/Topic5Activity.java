package md5e700a33d7957afb14167d0dd52202238;


public class Topic5Activity
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Automata_Teacher_3.Topic5Activity, Automata Teacher 3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Topic5Activity.class, __md_methods);
	}


	public Topic5Activity () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Topic5Activity.class)
			mono.android.TypeManager.Activate ("Automata_Teacher_3.Topic5Activity, Automata Teacher 3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	java.util.ArrayList refList;
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
