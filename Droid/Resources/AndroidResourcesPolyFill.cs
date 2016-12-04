using System;

// Workaround for OxyPlot not working with latest Android Xamarin.Forms:
// https://gist.github.com/rid00z/76906292010e080c7f5eadfb5ca7b107

namespace AppMetricaXamarin.Droid
{
    public partial class Resource
    {
        public partial class Attribute
        {
//            public const int mediaRoutePlayDrawable = -1;
            public const int mediaRouteSettingsDrawable = -2;
        }

        public partial class Color
        {
            public const int design_textinput_error_color = -1;
        }

        public partial class Dimension 
        {
            public const int design_fab_content_size = -1;
            public const int design_navigation_padding_top_default = -1;

            public const int design_tab_min_width = -1;
            public const int dialog_fixed_height_major = -1;
            public const int dialog_fixed_height_minor = -1;
            public const int dialog_fixed_width_major = -1;
            public const int dialog_fixed_width_minor = -1;
            public const int mr_media_route_controller_art_max_height = -1;
        }

        public partial class Drawable 
        {
            public const int ic_setting_dark = -1;
            public const int ic_setting_light = -1;
            public const int mr_ic_settings_dark = -1;
            public const int mr_ic_settings_light = -1;                       
        }

        public partial class Id
        {
            public const int art = -1;
            public const int buttons = -1;
            public const int default_control_frame = -1;
            public const int media_route_control_frame = -1;
            public const int media_route_list = -1;
            public const int media_route_volume_layout = -1;
            public const int media_route_volume_slider = -1;
            public const int play_pause = -1;
            public const int route_name = -1;
            public const int settings = -1;

            public const int stop = -1;
            public const int subtitle = -1;
            public const int title_bar = -1;
            public const int disconnect = -1;
        }

        public partial class Layout
        {
            public const int mr_media_route_chooser_dialog = -1;
            public const int mr_media_route_controller_material_dialog_b = -1;
            public const int mr_media_route_list_item = -1;
        }

        public partial class String
        {
            public const int mr_media_route_chooser_dialog = -1;
            public const int mr_media_route_controller_material_dialog_b = -1;
            public const int mr_media_route_list_item = -1;

            public const int mr_media_route_button_content_description = -1;
            public const int mr_media_route_chooser_searching = -1;
            public const int mr_media_route_chooser_title = -1;
            public const int mr_media_route_controller_disconnect = -1;
            public const int mr_media_route_controller_no_info_available = -1;
            public const int mr_media_route_controller_pause = -1;
            public const int mr_media_route_controller_play = -1;
            public const int mr_media_route_controller_settings_description = -1;
            public const int mr_media_route_controller_stop = -1;
        }

        public partial class Style
        {
            public const int RtlOverlay_Widget_AppCompat_ActionButton_Overflow = -1;

        }

        public partial class Styleable
        {
            public const int FloatingActionButton_android_background = -1;
            public const int[] Theme = null;
            public const int Theme_actionBarDivider = -1;
            public const int Theme_actionBarItemBackground = -1;
            public const int Theme_actionBarPopupTheme = -1;
            public const int Theme_actionBarSize = -1;
            public const int Theme_actionBarSplitStyle = -1;
            public const int Theme_actionBarStyle = -1;
            public const int Theme_actionBarTabBarStyle = -1;
            public const int Theme_actionBarTabStyle = -1;
            public const int Theme_actionBarTabTextStyle = -1;
            public const int Theme_actionBarTheme = -1;
            public const int Theme_actionBarWidgetTheme = -1;
            public const int Theme_actionButtonStyle = -1;
            public const int Theme_actionDropDownStyle = -1;
            public const int Theme_actionMenuTextAppearance = -1;
            public const int Theme_actionMenuTextColor = -1;
            public const int Theme_actionModeBackground = -1;
            public const int Theme_actionModeCloseButtonStyle = -1;
            public const int Theme_actionModeCloseDrawable = -1;
            public const int Theme_actionModeCopyDrawable = -1;
            public const int Theme_actionModeCutDrawable = -1;
            public const int Theme_actionModeFindDrawable = -1;
            public const int Theme_actionModePasteDrawable = -1;
            public const int Theme_actionModePopupWindowStyle = -1;
            public const int Theme_actionModeSelectAllDrawable = -1;
            public const int Theme_actionModeShareDrawable = -1;
            public const int Theme_actionModeSplitBackground = -1;
            public const int Theme_actionModeStyle = -1;
            public const int Theme_actionModeWebSearchDrawable = -1;
            public const int Theme_actionOverflowButtonStyle = -1;
            public const int Theme_actionOverflowMenuStyle = -1;
            public const int Theme_activityChooserViewStyle = -1;
            public const int Theme_alertDialogButtonGroupStyle = -1;
            public const int Theme_alertDialogCenterButtons = -1;
            public const int Theme_alertDialogStyle = -1;
            public const int Theme_alertDialogTheme = -1;
            public const int Theme_android_windowAnimationStyle = -1;
            public const int Theme_android_windowIsFloating = -1;
            public const int Theme_autoCompleteTextViewStyle = -1;
            public const int Theme_borderlessButtonStyle = -1;
            public const int Theme_buttonBarButtonStyle = -1;
            public const int Theme_buttonBarNegativeButtonStyle = -1;
            public const int Theme_buttonBarNeutralButtonStyle = -1;
            public const int Theme_buttonBarPositiveButtonStyle = -1;
            public const int Theme_buttonBarStyle = -1;
            public const int Theme_buttonStyle = -1;
            public const int Theme_buttonStyleSmall = -1;
            public const int Theme_checkboxStyle = -1;
            public const int Theme_checkedTextViewStyle = -1;
            public const int Theme_colorAccent = -1;
            public const int Theme_colorButtonNormal = -1;
            public const int Theme_colorControlActivated = -1;
            public const int Theme_colorControlHighlight = -1;
            public const int Theme_colorControlNormal = -1;
            public const int Theme_colorPrimary = -1;
            public const int Theme_colorPrimaryDark = -1;
            public const int Theme_colorSwitchThumbNormal = -1;
            public const int Theme_controlBackground = -1;
            public const int Theme_dialogPreferredPadding = -1;
            public const int Theme_dialogTheme = -1;
            public const int Theme_dividerHorizontal = -1;
            public const int Theme_dividerVertical = -1;
            public const int Theme_dropDownListViewStyle = -1;
            public const int Theme_dropdownListPreferredItemHeight = -1;
            public const int Theme_editTextBackground = -1;
            public const int Theme_editTextColor = -1;
            public const int Theme_editTextStyle = -1;
            public const int Theme_homeAsUpIndicator = -1;
            public const int Theme_listChoiceBackgroundIndicator = -1;
            public const int Theme_listDividerAlertDialog = -1;
            public const int Theme_listPopupWindowStyle = -1;
            public const int Theme_listPreferredItemHeight = -1;
            public const int Theme_listPreferredItemHeightLarge = -1;
            public const int Theme_listPreferredItemHeightSmall = -1;
            public const int Theme_listPreferredItemPaddingLeft = -1;
            public const int Theme_listPreferredItemPaddingRight = -1;
            public const int Theme_panelBackground = -1;
            public const int Theme_panelMenuListTheme = -1;
            public const int Theme_panelMenuListWidth = -1;
            public const int Theme_popupMenuStyle = -1;
            public const int Theme_popupWindowStyle = -1;
            public const int Theme_radioButtonStyle = -1;
            public const int Theme_ratingBarStyle = -1;
            public const int Theme_searchViewStyle = -1;
            public const int Theme_selectableItemBackground = -1;
            public const int Theme_selectableItemBackgroundBorderless = -1;
            public const int Theme_spinnerDropDownItemStyle = -1;
            public const int Theme_spinnerStyle = -1;
            public const int Theme_switchStyle = -1;
            public const int Theme_textAppearanceLargePopupMenu = -1;
            public const int Theme_textAppearanceListItem = -1;
            public const int Theme_textAppearanceListItemSmall = -1;
            public const int Theme_textAppearanceSearchResultSubtitle = -1;
            public const int Theme_textAppearanceSearchResultTitle = -1;
            public const int Theme_textAppearanceSmallPopupMenu = -1;
            public const int Theme_textColorAlertDialogListItem = -1;
            public const int Theme_textColorSearchUrl = -1;
            public const int Theme_toolbarNavigationButtonStyle = -1;
            public const int Theme_toolbarStyle = -1;
            public const int Theme_windowActionBar = -1;
            public const int Theme_windowActionBarOverlay = -1;
            public const int Theme_windowActionModeOverlay = -1;
            public const int Theme_windowFixedHeightMajor = -1;
            public const int Theme_windowFixedHeightMinor = -1;
            public const int Theme_windowFixedWidthMajor = -1;
            public const int Theme_windowFixedWidthMinor = -1;
            public const int Theme_windowMinWidthMajor = -1;
            public const int Theme_windowMinWidthMinor = -1;
            public const int Theme_windowNoTitle = -1;
        }

    }
}

