window.Blazaco = window.Blazaco || {};
window.Blazaco.Editors = [];

window.Blazaco.Editor = {
    InitializeEditor: function (model) {
        const thisEditor = monaco.editor.create(document.getElementById(model.id), model.options);
        if (window.Blazaco.Editors.find(e => e.id === model.id)) {
            return false;
        } else {
            window.Blazaco.Editors.push({ id: model.id, editor: thisEditor });
        }
        return true;
    },
    GetValue: function (id) {
        const myEditor = window.Blazaco.Editors.find(e => e.id === id);
        if (!myEditor) {
            throw `Could not find a editor with id: '${window.Blazaco.Editors.length}' '${id}'`;
        }
        return myEditor.editor.getValue();
    },
    SetValue: function (id, value) {
        const myEditor = window.Blazaco.Editors.find(e => e.id === id);
        if (!myEditor) {
            throw `Could not find a editor with id: '${window.Blazaco.Editors.length}' '${id}'`;
        }
        myEditor.editor.setValue(value);
        return true;
    },
    SetTheme: function (id, theme) {
        const myEditor = window.Blazaco.Editors.find(e => e.id === id);
        if (!myEditor) {
            throw `Could not find a editor with id: '${window.Blazaco.Editors.length}' '${id}'`;
        }
        monaco.editor.setTheme(theme);
        return true;
    },
    Layout: function (id, layoutInfo) {
        const myEditor = window.Blazaco.Editors.find(e => e.id === id);
        if (!myEditor) {
            throw `Could not find a editor with id: '${window.Blazaco.Editors.length}' '${id}'`;
        }
        monaco.editor.layout(layoutInfo);
        return true;
    }
};
