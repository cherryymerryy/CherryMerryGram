using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Media.Animation;
using Microsoft.UI.Xaml.Navigation;
using TdLib;
using TdLib.Bindings;
using CherryMerryGramDesktop;
using CherryMerryGramDesktop.Services;
using CherryMerryGramDesktop.Views.Chats;

namespace CherryMerryGramDesktop
{
	public sealed partial class MainWindow : Window
	{
		private NavigationViewItem _lastItem;
		private static TdClient _client = App._client;
		private NotificationService _notificationService;
		
		private int _totalUnreadCount = 0;
		
		public MainWindow()
		{
			InitializeComponent();
			Title = "CherryMerryGram";
            Window window = this;
            window.ExtendsContentIntoTitleBar = true;
            NavigateToView("ChatsView");
            TrySetDesktopAcrylicBackdrop();
            
            _client.UpdateReceived += async (_, update) => { await ProcessUpdates(update); };
            _notificationService = new NotificationService();
            
            var chatsIds = _client.ExecuteAsync(new TdApi.GetChats{Limit = 100}).Result.ChatIds;
            foreach (var chatId in chatsIds)
            {
	            var chat = _client.ExecuteAsync(new TdApi.GetChat {ChatId = chatId}).Result;
	            _totalUnreadCount += chat.UnreadCount;
            }
            
			UnreadMessagesCount.Value = _totalUnreadCount;
			
			var folders = _client.ExecuteAsync(new TdApi.GetRecommendedChatFolders()).Result.ChatFolders;
			foreach (var folder in folders)
			{
				folder.Folder.ExcludeArchived = true;
				var folderItem = new NavigationViewItem
				{
					Tag = "ChatsView",
					Content = folder.Folder.Title
				};
				NavViewChats.MenuItems.Add(folderItem);
			}
		}

		private async Task ProcessUpdates(TdApi.Update update)
		{
			switch (update)
			{
				case TdApi.Update.UpdateNewMessage updateNewMessage:
				{
					//_notificationService.SendNotification(updateNewMessage.Message);
					break;
				}
			}
		}

		private bool TrySetDesktopAcrylicBackdrop()
		{
			if (Microsoft.UI.Composition.SystemBackdrops.DesktopAcrylicController.IsSupported())
			{
				Microsoft.UI.Xaml.Media.DesktopAcrylicBackdrop DesktopAcrylicBackdrop = new Microsoft.UI.Xaml.Media.DesktopAcrylicBackdrop();
				SystemBackdrop = DesktopAcrylicBackdrop;

				return true;
			}

			return false;
		}
		
		private void ContentFrame_NavigationFailed(object sender, NavigationFailedEventArgs e) 
		{

		}

		private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
		{
			var item = args.InvokedItemContainer as NavigationViewItem;
			if (item == null || item == _lastItem)
				return;

			var clickedView = item.Tag.ToString() ?? "SettingsView";

			if (!NavigateToView(clickedView)) return;
			_lastItem = item;
		}

		private bool NavigateToView(string clickedView)
		{
			var view = Assembly.GetExecutingAssembly().GetType($"CherryMerryGramDesktop.Views.{clickedView}");

			if (string.IsNullOrEmpty(clickedView) || view == null)
				return false;

			ContentFrame.Navigate(view, null, new EntranceNavigationTransitionInfo());
			return true;
        }

        private void NavView_Loaded(object sender, RoutedEventArgs e)
		{
			
		}

		private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
		{

		}
    }
}
