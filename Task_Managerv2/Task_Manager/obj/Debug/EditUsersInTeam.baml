   M S B A M L   `   `   `  ����G  CTask_Manager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Task_ManagerTask_Manager  5      "    Task_Manager.EditUsersInTeam   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:Task_Manager     5        N� Title$  EditUsersInTeam��5	       � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ 32��6'   �� 5       � ��$	 171��6&   �� 5       � ��$ Center=�6;   �� 5       � ��$ Center=�69   5      5      .��5      � .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��
dgAllUsers��5      $��22,24,687,24q�6%      AutoGenerateColumns .     
IsReadOnly .    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6%   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6W   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 66   �� *user_surname+6W     5      $ Имя��6%   $	 * 6P   
 62   �� *	user_name+6P   5        5   
   -   5        $��dgAllUsers2��5      $��22,24,687,24q�6&    .   .  5        5      $ Фамилия��6%   $	 * 6W   
 66   �� *user_surname+6W     5      $ Имя��6%   $	 * 6P   
 62   �� *	user_name+6P   5!        5"   
   -   5        $��dgSelectedUsers��5"      $��687,24,21,24q�6*    .   .  5#        5$      $ Фамилия��6%   $	 * 6W   
 66   �� *user_surname+6W     5%      $ Имя��6%   $	 * 6P   
 62   �� *	user_name+6P   5'        5(   
   -   5        $��dgSelectedUsers2��5(      $��687,24,21,24q�6+    .   .  5)        5*      $ Фамилия��6%   $	 * 6W   
 66   �� *user_surname+6W     5+      $ Имя��6%   $	 * 6P   
 62   �� *	user_name+6P   5-      �� 5.   
   -   5        $��
txtSeartch��5.      $��Center=�6$   $��	0,199,0,0q�6A    �� TextWrapping$
 Wrap=�6T   $	��Top=�6h   $	��120��6�   6�   �� 5/   
   -   5        $��btnAdd��5/      $��Добавить��6   $��Center=�62   $	��Top=�6O   $	��120��6g   $��	0,245,0,0q�6s   6�   �� 50   
   -   5        $��	btnDelete��50      $��Удалить��6"   $��Center=�64   $��	0,288,0,0q�6Q   $	��Top=�6d   $	��120��6|   6�   �� 51   
   -   5         ��Name$ btnBack��51      $��
Назад��6"   $��Center=�62   $��	0,329,0,0q�6O   $	��Top=�6b   $	��120��6z   6�   �� 52   
   $$��Поиск по фамилии��6   $��Center=�6+   $��	0,175,0,0q�6H   $	��Top=�6[   $��Segoe UI Semibold)�6s   54      55      