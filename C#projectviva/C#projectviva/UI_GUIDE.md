# UI Standard — clean beginner WinForms (matches CS107.3 level)

Goal: every screen looks like a tidy, STANDARD Visual Studio Windows Forms app that a university
student team would build. Use ONLY the standard WinForms toolbox. Keep it simple and consistent.

## How forms are built (Visual Studio Designer)
Forms are now **Visual Studio Designer-based**. Each form is three files:
`XxxForm.cs` (your event handlers / logic), `XxxForm.Designer.cs` (the controls and their layout),
and `XxxForm.resx` (the form's resources). You can build a screen by **dragging controls in the
VS designer** (recommended — drag-and-drop, set properties in the Properties window) OR by editing
`XxxForm.Designer.cs` in code — **both are fine**, whichever you are comfortable with.
This is safe for the team because each member owns ONE module folder and works on their OWN branch,
so two people never edit the same form / `.resx` at once. The colour, font, button and grid
standards below apply **the same way** no matter which method you use. The new **Payroll** screen
(`PayrollForm`) follows this exact same standard.

## Allowed controls (the standard toolbox)
Label · TextBox · Button · ComboBox · DateTimePicker · DataGridView · GroupBox · Panel · ListBox · MaskedTextBox.
No third-party controls, no custom-drawn UI, no theming libraries.

## Control naming (use these prefixes — like the course's btnSubmit / txtName / lblResult)
- `lbl` Label  · `txt` TextBox · `btn` Button · `cmb` ComboBox · `dtp` DateTimePicker
- `dgv` DataGridView · `grp` GroupBox · `pnl` Panel
Event handler methods: `private void btnAdd_Click(object sender, EventArgs e) { ... }`

## Standard layout for EVERY data screen
1. Form: `StartPosition = CenterScreen`; `FormBorderStyle = FixedSingle`; `MaximizeBox = false`;
   `Text = "Tea Estate — <Screen Name>"`; base `Font = new Font("Segoe UI", 9F)`; size about 780 x 540.
2. Header: a `Panel` docked Top (Height 46, BackColor = Color.FromArgb(34,139,34), ForeColor white)
   holding a bold `Label` "<Screen Name>" in Segoe UI 13.5 Bold.
3. Inputs: a `GroupBox` titled "Details" (left side). Field labels on the left, the control to its right,
   aligned in a column with even ~34px row spacing. TextBoxes ~190 wide. Use ComboBox for choices
   (worker, section, status, role) and DateTimePicker for dates.
4. Data: a `DataGridView` filling the rest of the form. `ReadOnly=true`, `AllowUserToAddRows=false`,
   `MultiSelect=false`, `SelectionMode=FullRowSelect`, `AutoSizeColumnsMode=Fill`,
   `RowHeadersVisible=false`, AlternatingRows light grey.
5. Buttons: a row under the inputs, each `Size = 92x30`, 8px apart, in order: Add, Update, Delete, Clear, Refresh
   (only the ones that apply to that screen).
6. Clicking a grid row fills the inputs for editing (`dgv.CellClick`).

## Correctness rules (this is also the bug checklist)
- Validate before saving: required fields not blank; numbers via `int.TryParse` / `decimal.TryParse`
  (show a MessageBox and STOP on bad input — never let bad input crash the app).
- ComboBox of workers/sections: set `DisplayMember` (name) and `ValueMember` (id); read the id with
  `Convert.ToInt32(cmb.SelectedValue)` and guard `cmb.SelectedValue == null` (nothing selected).
- Read DataRow / grid cells safely: check `DBNull.Value` before `Convert.ToXxx`.
- INSERT statements must NOT include the IDENTITY primary key (WorkerID/AttendanceID/... are auto).
- SQL: always bracket the reserved words `[User]` and `[Date]`.
- Repository `GetAll()` column names (and any SQL aliases) MUST match the names the form reads.
- Every DB call in `try/catch` → `MessageBox.Show(ex.Message, "Error")`.
- After Add/Update/Delete: refresh the grid and clear the inputs. Confirm deletes with a Yes/No MessageBox.

## Consistency
Same header colour, same button sizes, same fonts on every form — so the whole app feels like one product.
