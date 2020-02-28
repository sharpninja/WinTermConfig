window.Blazaco = window.Blazaco || {};
window.Blazaco.Editors = [];

window.Blazaco.Editor = {
    InitializeEditor: function (model) {
        const thisEditor = monaco.editor.create(document.getElementById(model.id), model.options);
        if (window.Blazaco.Editors.find(e => e.id === model.id)) {
            return false;
        } else {
            window.CurrentEditor = thisEditor;
            window.Blazaco.Editors.push({ id: model.id, editor: thisEditor });

            window.onresize = () => window.CurrentEditor.layout();
        }
        return true;
    },
    UpdateOptions: function(id, editorOptions) {
        const myEditor = window.Blazaco.Editors.find(e => e.id === id);
        if (!myEditor) {
            throw `Could not find a editor with id: '${window.Blazaco.Editors.length}' '${id}'`;
        }
        window.CurrentEditor = myEditor;
        window.CurrentEditor.editor.updateOptions(editorOptions);
        return true;
    },
    GetValue: function (id) {
        const myEditor = window.Blazaco.Editors.find(e => e.id === id);
        if (!myEditor) {
            throw `Could not find a editor with id: '${window.Blazaco.Editors.length}' '${id}'`;
        }
        window.CurrentEditor = myEditor;
        return window.CurrentEditor.editor.getValue();
    },
    SetValue: function (id, value) {
        const myEditor = window.Blazaco.Editors.find(e => e.id === id);
        if (!myEditor) {
            throw `Could not find a editor with id: '${window.Blazaco.Editors.length}' '${id}'`;
        }
        window.CurrentEditor = myEditor;
        window.CurrentEditor.editor.setValue(value);
        return true;
    },
    SetTheme: function (id, theme) {
        const myEditor = window.Blazaco.Editors.find(e => e.id === id);
        if (!myEditor) {
            throw `Could not find a editor with id: '${window.Blazaco.Editors.length}' '${id}'`;
        }
        window.CurrentEditor = myEditor;
        window.CurrentEditor.editor.setTheme(theme);
        return true;
    },
    Layout: function (id, layoutInfo) {
        const myEditor = window.Blazaco.Editors.find(e => e.id === id);
        if (!myEditor) {
            throw `Could not find a editor with id: '${window.Blazaco.Editors.length}' '${id}'`;
        }
        window.CurrentEditor = myEditor;
        window.CurrentEditor.editor.layout(layoutInfo);
        return true;
    }
};
