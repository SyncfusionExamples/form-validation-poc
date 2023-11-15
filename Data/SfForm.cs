using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
namespace FormValidationPOC.Data
{
    public class SfForm
    {
        /// <summary>
        /// Gets or sets the value of the the autocomplete attribute of the form. 
        /// </summary>
        /// <value>
        /// <c>on</c>, The browser is allowed to automatically complete the input field based on the user's previous inputs.
        /// <c>off</c>, The browser is not allowed to automatically complete the input field.
        /// </value>
        /// <remarks>
        /// 
        /// </remarks>
        public string AutoComplete = "On";
        /// <summary>
        /// Gets or sets the alignment of the form buttons.
        /// </summary>
        /// <value>
        /// The alignment options are:
        /// <c>Left</c> : Aligns the form buttons to the left side of the form.
        /// <c>Center</c> : Centers the form buttons within the form.
        /// <c>Right</c> : Aligns the form buttons to the right side of the form.
        /// </value>
        ///<remarks>
        /// The form buttons can be aligned to the left, center, or right.
        /// </remarks>
        public FormButtonsAlignment ButtonsAlignment { get; set; }
        /// <summary>
        /// Gets or sets the count of columns in form grid layout.
        /// </summary>
        /// <value>
        /// An int that specifies the number of columns layout render in Form component.
        /// </value>
        public int Columns { get; set; } = 1;
        /// <summary>
        /// Gets or sets the ID of the form.
        /// </summary>
        /// <value>
        /// String value that specifies the Id of the form.
        /// </value>
        public string ID { get; set; }
        /// <summary>
        /// Gets or sets the spacing between columns in a form grid layout.
        /// </summary>
        /// <value>
        /// String value that specifies the spacing between columns in a form grid layout of the form.
        /// </value>
        public string ColumnSpacing { get; set; }
        /// <summary>
        /// Gets or sets the EditContext of the form. The user should specify either EditContext, or <see cref="Model"/>. 
        /// </summary>
        /// <value>
        /// <see cref="Microsoft.AspNetCore.Components.Forms.EditContext"/>
        /// </value>
        /// <remarks>
        /// If using this <see cref="EditContext"/>, do not also supply <see cref="Model"/>, since the model value will be taken from the Model property.
        /// </remarks>
        public EditContext EditContext { get; set; }
        /// <summary>
        /// Gets or sets the template for the form buttons.
        /// </summary>
        /// <value>
        /// The template content. The default value is render Submit button.
        /// </value>
        public RenderFragment FormButtons { get; set; }
        /// <summary>
        /// Gets or sets the template for the form items.
        /// </summary>
        /// <value>
        /// The template content. The default value is null.
        /// </value>
        public RenderFragment FormItems { get; set; }
        /// <summary>
        /// Gets or sets the template for the form items to provide the custom components.
        /// </summary>
        /// <value>
        ///  The template content. The default value is null.
        /// </value>
        public RenderFragment FormItemsTemplate { get; set; }
        /// <summary>
        /// Gets or sets the template for the validation type.
        /// </summary>
        /// <value>
        ///  The template content. The default value is null.
        /// </value>
        public RenderFragment FormValidation { get; set; }
        /// <summary>
        /// Gets or Sets the position of labels in the form form field items.
        /// </summary>
        /// <value>
        /// The position options are:
        /// <c>Top</c> : The labels are positioned above the form fields.
        /// <c>Left</c> : The labels are positioned to the left of the form fields.
        /// </value>
        public FormLabelPosition LabelPosition { get; set; }
        /// <summary>
        /// Gets or Sets the way the validation errors should be displayed.
        /// </summary>
        /// <value>
        /// The display options are:
        /// <c>Inline</c> : The validation message is displayed below the form field.
        /// <c>ToolTip</c> : The validation message is displayed in a tooltip.
        /// <c>None</c> : No validation messages are rendered. Useful when user want to have only ValidationSummary to show error messages..
        /// </value>
        public FormValidationMessageDisplay ValidationMessageDisplay { get; set; }
        /// <summary>
        /// Gets or sets the Width of the form.
        /// </summary>
        /// <value>
        /// String value, The default value is 100%.
        /// </value>
        public string Width { get; set; }

        /// <summary>
        /// Gets the updated filed name of the Form.
        /// </summary>
    }

    public class FormItems<TValue>
    {
        /// <summary>
        /// Gets or sets one or more CSS classes that can be used to customize the appearance of a form field.
        /// </summary>
        /// <value> 
        /// One or more CSS classes to customize the appearance of the form field, such as by changing its colors, fonts, sizes, or other visual aspects.
        /// The default value is <c>String.Empty</c>. 
        /// </value
        public string CssClass { get; set; }
        /// <summary>
        /// Gets or sets the number of columns spanned by the cell.
        /// </summary>
        /// <value>
        /// The number of columns spanned by the cell.
        /// </value>
        public int ColSpan { get; set; }
        /// <summary>
        /// Gets or sets the editor used for the given field. If not provided, a default editor will be used based on the field data type.
        /// </summary>
        /// <value>
        /// <see cref="FormEditorType"/>
        /// </value>
        public FormEditorType EditorType { get; set; }
        /// <summary>
        /// Gets or sets a value that specifies whether a form field is enabled or disabled.
        /// </summary>
        /// <value>
        /// <c>false</c>, the form field will be disabled and the user will not be able to interact with it. The default value is <c>true</c>. 
        /// </value>
        public bool IsEditable { get; set; }
         public TValue Field { get; set; }
        public TValue FieldType { get; set; }
        /// <summary>
        /// Gets or sets the placeholder text for a form field.
        /// </summary>
        /// <value>
        /// String value that specifies the placeholder text.
        /// </value>
        public string Placeholder { get; set; }


    }

    public enum FormEditorType
    {
        /// <summary>
        /// The form field uses a text editor.
        /// </summary>
        TextBox,

        /// <summary>
        /// The form field uses a dropdown list editor.
        /// </summary>
        DropdownList,
        /// <summary>
        /// The form field uses a ComboBox editor.
        /// </summary>
        ComboBox,

        /// <summary>
        /// The form field uses a AutoComplete editor.
        /// </summary>
        AutoComplete,

        /// <summary>
        /// The form field uses a checkbox editor.
        /// </summary>
        Checkbox,

        /// <summary>
        /// The form field uses a date picker editor.
        /// </summary>
        DatePicker,

        ///<summary>
        ///The form field uses a date time picker editor.
        ///</summary>
        DateTimePicker,
        /// <summary>
        /// The form field uses a time picker editor.
        /// </summary>
        TimePicker,
        /// <summary>
        /// The form field uses a Switch editor.
        /// </summary>
        Switch

    }
    /// <summary>
    /// Specifies the alignment of the form buttons.
    /// </summary>
    public enum FormButtonsAlignment
    {
        /// <summary>
        /// The form buttons are aligned to the left.
        /// </summary>
        Left,

        /// <summary>
        /// The form buttons are aligned to the center.
        /// </summary>
        Center,

        /// <summary>
        /// The form buttons are aligned to the right.
        /// </summary>
        Right
    }
    /// <summary>
    /// Specifies the position of labels in a form field item.
    /// </summary>
    public enum FormLabelPosition
    {
        /// <summary>
        /// The labels are positioned above the form fields.
        /// </summary>
        Top,

        /// <summary>
        /// The labels are positioned to the left of the form fields.
        /// </summary>
        Left,
    }
    public enum FormValidationMessageDisplay
    {
        /// <summary>
        /// The validation message is displayed below the form field.
        ///</summary>
        Inline,
        /// <summary>
        /// No validation messages are rendered. Useful when user want to have only ValidationSummary to show error messages..
        /// </summary>
        None,
        ///<summary>
        /// The validation message is displayed in a tooltip.
        /// </summary>
        Tooltip
    }
}
