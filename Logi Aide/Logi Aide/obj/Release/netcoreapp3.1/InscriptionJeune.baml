   M S B A M L   `   `   `  ���� D  @Logi Aide, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Logi_Aide	Logi_Aide       Logi_Aide.InscriptionJeune   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     )localclr-namespace:Logi_Aide       � Title$  InscriptionJeune��$	��450��$	��800��.��� 
������� � ColumnDefinitions �� $��1* ��� $��2* �.+��� $��0��.+��� $��logoNoir.PNG��$	��180��$	��Top=�$��
30,20,0,15q�$
��Left=�$	��Top=��� $��Image de profil : ��$��30,0,0,0q�$��20(�� $��30,5,0,5q� �� $��2* ��� .+��� $��0���� $��1��$��Parcourir ...���� $��Nouvelle identifiant : ��$��30,0,0,0q�$��20(��� $��25��$	��230��$��	30,5,0,15q��� $��Annuler��
�������
���  ��
���  ��$	��230��$��5q�$��	30,0,0,10q��� $��Valider��
�������
��� � �
��� d �$	��230��$��5q�$��	30,0,0,20q��� $��1��.+��� $��Inscription��$��24(�$��
30,10,0,10q�$
��Bold"�� $��	30,0,20,0q� �� �� $	��200 � � RowDefinitions �� �� �� �� �� �� �� �� �� �� .+��� $��0��$��0��$��*Nom : ��$��14(��� $��1��$��0��$��1q�$
��Auto=��� $��0��$��1��$��*Prénom : ��$��14(��� $��1��$��1��$��1q�$
��Auto=��� $��0��$��2��$��*Age : ��$��14(��� $��1��$��2��$��1q�$
��Auto=��� $��0��$��3��$��Numéro de téléphone : ��$��14(��� $��1��$��3��$��1q�$
��Auto=��� $��0��$��4��$��Mail : ��$��14(��� $��1��$��4��$��1q�$
��Auto=��� $��0��$��5��$��Lieux de naissance : ��$��14(��� $��1��$��5��$��1q�$
��Auto=��� $��0��$��6��$��Avec qui vivez-vous : ��$��14(��� $��1��$��6��$��1q�$
��Auto=��� $��0��$��7��$0��*Raison principale de votre immigration :  ��$��14(��� $��1��$��7��$��1q�$
��Auto=��� $��0��$��8��$(��"Raison de votre venue en France : ��$��14(��� $��1��$��8��$��1q�$
��Auto=��� $��0��$��9��$��	Projet : ��$��14(��� $��1��$��9��$��1q�$
��Auto=��� $A��; Quel est le dernier titre d'étude que vous avez atteint :��$��14(�$��30,2,0,0q�� $��	50,0,20,0q� �� �� �� .+��� $��0��.��Aucun�� $��1��$��10,0,0,0q�.��Ecoles élémentaires�� $��2��$��10,0,0,0q�.��Ecoles secondaires�� $��Décrivez votre santé :��$��14(�$��30,2,0,0q�� $��	50,0,20,0q� �� �� �� �� .+��� $��0��.��Très mauvaise�� $��1��$��10,0,0,0q�.��
Mauvaise�� $��2��$��10,0,0,0q�.��Faible�� $��3��$��10,0,0,0q�.��Bonne�� $*��$ Décrivez votre situation sociale :��$��14(�$��30,2,0,0q�� $��	50,0,20,0q� �� �� �� �� .+��� $��0��.��Très mauvaise�� $��1��$��10,0,0,0q�.��
Mauvaise�� $��2��$��10,0,0,0q�.��
Suffisante�� $��3��$��10,0,0,0q�.��Bonne�� $��
A propos :��$��14(�$��30,2,0,0q��� $��	30,2,20,0q� �� AcceptsReturn$
 True�� �� TextWrapping$
 Wrap=� �� 	IsEnabled$
 True��$
��Auto=��� $��*obligatoire��$��30,0,0,0q�