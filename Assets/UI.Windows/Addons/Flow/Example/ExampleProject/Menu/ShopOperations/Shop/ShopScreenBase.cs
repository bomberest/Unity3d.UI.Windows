//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the UI.Windows Flow Addon.
//     You may not edit this file because of it's auto-generated by FlowCompiler.
//     See more: https://github.com/chromealex/Unity3d.UI.Windows
// </auto-generated>
//------------------------------------------------------------------------------
using UnityEngine;
using UnityEngine.UI.Windows;
using UnityEngine.UI.Windows.Types;

namespace ExampleProject.UI.Menu.ShopOperations.Shop {

	public class ShopScreenBase : LayoutWindowType {
		
		/// <summary>
		/// Request Social Module.
		/// Platform: VK (vk.com)
		/// </summary>
		/// <returns>Social VK Module</returns>
		public virtual UnityEngine.UI.Windows.Plugins.Social.Modules.Impl.VK.VKModule GetSocialModule() {
			
			return UnityEngine.UI.Windows.Plugins.Social.Core.SocialSystem.instance.GetModule<UnityEngine.UI.Windows.Plugins.Social.Modules.Impl.VK.VKModule>();
			
		}
		
	}

}