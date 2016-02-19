(function() {
	'use strict';
	var $asm = {};
	global.NERP = global.NERP || {};
	global.NERP.Accounting = global.NERP.Accounting || {};
	global.NERP.Administration = global.NERP.Administration || {};
	global.NERP.Common = global.NERP.Common || {};
	global.NERP.Configuration = global.NERP.Configuration || {};
	global.NERP.HR = global.NERP.HR || {};
	global.NERP.Inventory = global.NERP.Inventory || {};
	global.NERP.ItemTransaction = global.NERP.ItemTransaction || {};
	global.NERP.Membership = global.NERP.Membership || {};
	global.NERP.Northwind = global.NERP.Northwind || {};
	global.NERP.Purchase = global.NERP.Purchase || {};
	global.NERP.Sales = global.NERP.Sales || {};
	global.Serenity = global.Serenity || {};
	ss.initAssembly($asm, 'NERP.Script');
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Authorization
	var $NERP_Authorization = function() {
	};
	$NERP_Authorization.__typeName = 'NERP.Authorization';
	$NERP_Authorization.get_userDefinition = function() {
		return Q.getRemoteData('UserData');
	};
	$NERP_Authorization.hasPermission = function(permissionKey) {
		return $NERP_Authorization.get_userDefinition().Permissions[permissionKey];
	};
	global.NERP.Authorization = $NERP_Authorization;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ScriptInitialization
	var $NERP_ScriptInitialization = function() {
	};
	$NERP_ScriptInitialization.__typeName = 'NERP.ScriptInitialization';
	global.NERP.ScriptInitialization = $NERP_ScriptInitialization;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Accounting.COADialog
	var $NERP_Accounting_COADialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Accounting_COAForm(this.get_idPrefix());
	};
	$NERP_Accounting_COADialog.__typeName = 'NERP.Accounting.COADialog';
	global.NERP.Accounting.COADialog = $NERP_Accounting_COADialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Accounting.COAForm
	var $NERP_Accounting_COAForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Accounting_COAForm.__typeName = 'NERP.Accounting.COAForm';
	global.NERP.Accounting.COAForm = $NERP_Accounting_COAForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Accounting.COAGrid
	var $NERP_Accounting_COAGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Accounting_COAGrid.__typeName = 'NERP.Accounting.COAGrid';
	global.NERP.Accounting.COAGrid = $NERP_Accounting_COAGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.LanguageDialog
	var $NERP_Administration_LanguageDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$NERP_Administration_LanguageDialog.__typeName = 'NERP.Administration.LanguageDialog';
	global.NERP.Administration.LanguageDialog = $NERP_Administration_LanguageDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.LanguageForm
	var $NERP_Administration_LanguageForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Administration_LanguageForm.__typeName = 'NERP.Administration.LanguageForm';
	global.NERP.Administration.LanguageForm = $NERP_Administration_LanguageForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.LanguageGrid
	var $NERP_Administration_LanguageGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Administration_LanguageGrid.__typeName = 'NERP.Administration.LanguageGrid';
	global.NERP.Administration.LanguageGrid = $NERP_Administration_LanguageGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.PermissionCheckEditor
	var $NERP_Administration_PermissionCheckEditor = function(div, opt) {
		this.$containsText = null;
		this.$byParentKey = null;
		this.$rolePermissions = null;
		ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).call(this, div, opt);
		this.$rolePermissions = {};
		var titleByKey = {};
		var permissionKeys = this.$getSortedGroupAndPermissionKeys(titleByKey);
		var items = [];
		for (var $t1 = 0; $t1 < permissionKeys.length; $t1++) {
			var key = permissionKeys[$t1];
			items.push({ Key: key, ParentKey: this.$getParentKey(key), Title: titleByKey.$[key], GrantRevoke: null, IsGroup: ss.endsWithString(key, ':') });
		}
		this.$byParentKey = Enumerable.from(items).toLookup(function(x) {
			return x.ParentKey;
		});
		this.$setItems(items);
	};
	$NERP_Administration_PermissionCheckEditor.__typeName = 'NERP.Administration.PermissionCheckEditor';
	global.NERP.Administration.PermissionCheckEditor = $NERP_Administration_PermissionCheckEditor;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.PermissionModuleEditor
	var $NERP_Administration_PermissionModuleEditor = function(hidden) {
		ss.makeGenericType(Serenity.Select2Editor$2, [Object, String]).call(this, hidden, null);
		var modules = {};
		var permissions = Q.getRemoteData('Administration.PermissionKeys').Entities;
		for (var i = 0; i < permissions.length; i++) {
			var k = permissions[i];
			var idx1 = k.indexOf(String.fromCharCode(58));
			if (idx1 <= 0) {
				continue;
			}
			var idx2 = k.indexOf(String.fromCharCode(58), idx1 + 1);
			if (idx2 <= 0) {
				continue;
			}
			var module = k.substr(0, idx1);
			modules[module] = true;
		}
		var othersModule = false;
		for (var $t1 = 0; $t1 < permissions.length; $t1++) {
			var k1 = permissions[$t1];
			var idx11 = k1.indexOf(String.fromCharCode(58));
			if (idx11 < 0 && !ss.isValue(modules[k1])) {
				othersModule = true;
				break;
			}
		}
		var moduleList = [];
		ss.arrayAddRange(moduleList, Object.keys(modules));
		if (othersModule) {
			moduleList.push('Common');
		}
		for (var $t2 = 0; $t2 < moduleList.length; $t2++) {
			var k2 = moduleList[$t2];
			this.addItem$1(k2, k2, k2, false);
		}
	};
	$NERP_Administration_PermissionModuleEditor.__typeName = 'NERP.Administration.PermissionModuleEditor';
	global.NERP.Administration.PermissionModuleEditor = $NERP_Administration_PermissionModuleEditor;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.RoleCheckEditor
	var $NERP_Administration_RoleCheckEditor = function(div) {
		this.$containsText = null;
		ss.makeGenericType(Serenity.CheckTreeEditor$1, [Object]).call(this, div, null);
	};
	$NERP_Administration_RoleCheckEditor.__typeName = 'NERP.Administration.RoleCheckEditor';
	global.NERP.Administration.RoleCheckEditor = $NERP_Administration_RoleCheckEditor;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.RoleDialog
	var $NERP_Administration_RoleDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$NERP_Administration_RoleDialog.__typeName = 'NERP.Administration.RoleDialog';
	global.NERP.Administration.RoleDialog = $NERP_Administration_RoleDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.RoleForm
	var $NERP_Administration_RoleForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Administration_RoleForm.__typeName = 'NERP.Administration.RoleForm';
	global.NERP.Administration.RoleForm = $NERP_Administration_RoleForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.RoleGrid
	var $NERP_Administration_RoleGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Administration_RoleGrid.__typeName = 'NERP.Administration.RoleGrid';
	global.NERP.Administration.RoleGrid = $NERP_Administration_RoleGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.RolePermissionDialog
	var $NERP_Administration_RolePermissionDialog = function(opt) {
		this.$permissions = null;
		ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).$ctor1.call(this, opt);
		this.$permissions = new $NERP_Administration_PermissionCheckEditor(this.byId$1('Permissions'), { showRevoke: false });
		Q.serviceRequest('Administration/RolePermission/List', { RoleID: this.options.roleID, Module: null, Submodule: null }, ss.mkdel(this, function(response) {
			this.$permissions.set_value(Enumerable.from(response.Entities).select(function(x) {
				return { PermissionKey: x };
			}).toArray());
		}), null);
	};
	$NERP_Administration_RolePermissionDialog.__typeName = 'NERP.Administration.RolePermissionDialog';
	global.NERP.Administration.RolePermissionDialog = $NERP_Administration_RolePermissionDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.TranslationGrid
	var $NERP_Administration_TranslationGrid = function(container) {
		this.$searchText = null;
		this.$sourceLanguage = null;
		this.$targetLanguage = null;
		this.$targetLanguageKey = null;
		this.$hasChanges = false;
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
		this.element.on('keyup.' + this.uniqueName + ' change.' + this.uniqueName, 'input.custom-text', ss.mkdel(this, function(e) {
			var value = Q.trimToNull($(e.target).val());
			if (value === '') {
				value = null;
			}
			this.view.getItemById($(e.target).data('key')).CustomText = value;
			this.$hasChanges = true;
		}));
	};
	$NERP_Administration_TranslationGrid.__typeName = 'NERP.Administration.TranslationGrid';
	global.NERP.Administration.TranslationGrid = $NERP_Administration_TranslationGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.UserDialog
	var $NERP_Administration_UserDialog = function() {
		this.$form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.$form = new $NERP_Administration_UserForm(this.get_idPrefix());
		Serenity.VX.addValidationRule(this.$form.get_password(), this.uniqueName, ss.mkdel(this, function(e) {
			if (this.$form.get_password().get_value().length < 7) {
				return 'Password must be at least 7 characters!';
			}
			return null;
		}));
		Serenity.VX.addValidationRule(this.$form.get_passwordConfirm(), this.uniqueName, ss.mkdel(this, function(e1) {
			if (!ss.referenceEquals(this.$form.get_password().get_value(), this.$form.get_passwordConfirm().get_value())) {
				return "The passwords entered doesn't match!";
			}
			return null;
		}));
	};
	$NERP_Administration_UserDialog.__typeName = 'NERP.Administration.UserDialog';
	global.NERP.Administration.UserDialog = $NERP_Administration_UserDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.UserForm
	var $NERP_Administration_UserForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Administration_UserForm.__typeName = 'NERP.Administration.UserForm';
	global.NERP.Administration.UserForm = $NERP_Administration_UserForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.UserGrid
	var $NERP_Administration_UserGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Administration_UserGrid.__typeName = 'NERP.Administration.UserGrid';
	global.NERP.Administration.UserGrid = $NERP_Administration_UserGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.UserPermissionDialog
	var $NERP_Administration_UserPermissionDialog = function(opt) {
		this.$permissions = null;
		ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).$ctor1.call(this, opt);
		this.$permissions = new $NERP_Administration_PermissionCheckEditor(this.byId$1('Permissions'), { showRevoke: true });
		Q.serviceRequest('Administration/UserPermission/List', { UserID: this.options.userID, Module: null, Submodule: null }, ss.mkdel(this, function(response) {
			this.$permissions.set_value(response.Entities);
		}), null);
		Q.serviceRequest('Administration/UserPermission/ListRolePermissions', { UserID: this.options.userID, Module: null, Submodule: null }, ss.mkdel(this, function(response1) {
			this.$permissions.set_rolePermissions(response1.Entities);
		}), null);
	};
	$NERP_Administration_UserPermissionDialog.__typeName = 'NERP.Administration.UserPermissionDialog';
	global.NERP.Administration.UserPermissionDialog = $NERP_Administration_UserPermissionDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Administration.UserRoleDialog
	var $NERP_Administration_UserRoleDialog = function(opt) {
		this.$permissions = null;
		ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).$ctor1.call(this, opt);
		this.$permissions = new $NERP_Administration_RoleCheckEditor(this.byId$1('Roles'));
		Q.serviceRequest('Administration/UserRole/List', { UserID: this.options.userID }, ss.mkdel(this, function(response) {
			this.$permissions.set_value(Enumerable.from(response.Entities).select(function(x) {
				return x.toString();
			}).toArray());
		}), null);
	};
	$NERP_Administration_UserRoleDialog.__typeName = 'NERP.Administration.UserRoleDialog';
	global.NERP.Administration.UserRoleDialog = $NERP_Administration_UserRoleDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Common.ExcelExportHelper
	var $NERP_Common_ExcelExportHelper = function() {
	};
	$NERP_Common_ExcelExportHelper.__typeName = 'NERP.Common.ExcelExportHelper';
	$NERP_Common_ExcelExportHelper.createToolButton = function(grid, service, onViewSubmit, title) {
		return {
			title: title,
			cssClass: 'export-xlsx-button',
			onClick: function() {
				if (!onViewSubmit()) {
					return;
				}
				var request = Q.deepClone(grid.getView().params);
				request.Take = 0;
				request.Skip = 0;
				var sortBy = grid.getView().sortBy;
				if (ss.isValue(sortBy)) {
					request.Sort = sortBy;
				}
				request.IncludeColumns = [];
				var $t1 = grid.getGrid().getColumns();
				for (var $t2 = 0; $t2 < $t1.length; $t2++) {
					var column = $t1[$t2];
					var $t4 = request.IncludeColumns;
					var $t3 = column.id;
					if (ss.isNullOrUndefined($t3)) {
						$t3 = column.field;
					}
					$t4.push($t3);
				}
				Q.postToService({ service: service, request: request, target: '_blank' });
			}
		};
	};
	global.NERP.Common.ExcelExportHelper = $NERP_Common_ExcelExportHelper;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Common.GridEditorBase
	var $NERP_Common_GridEditorBase$1 = function(TEntity) {
		var $type = function(container) {
			this.$nextId = 1;
			ss.makeGenericType(Serenity.EntityGrid$1, [TEntity]).call(this, container);
		};
		ss.registerGenericClassInstance($type, $NERP_Common_GridEditorBase$1, [TEntity], {
			id: function(entity) {
				return ss.cast(entity.__id, ss.Int32);
			},
			save: function(opt, callback) {
				var request = opt.request;
				var row = Q.deepClone(request.Entity);
				var id = ss.cast(row.__id, ss.Int32);
				if (ss.isNullOrUndefined(id)) {
					row.__id = this.$nextId++;
				}
				if (!this.validateEntity(row, id)) {
					return;
				}
				var items = ss.arrayClone(this.view.getItems());
				if (ss.isNullOrUndefined(id)) {
					items.push(row);
				}
				else {
					var index = Enumerable.from(items).indexOf(ss.mkdel(this, function(x) {
						return this.id(x) === ss.unbox(id);
					}));
					items[index] = Q.deepClone(ss.createInstance(TEntity), items[index], row);
				}
				this.setEntities(items);
				callback({});
			},
			deleteEntity: function(id) {
				this.view.deleteItem(id);
				return true;
			},
			validateEntity: function(row, id) {
				return true;
			},
			setEntities: function(items) {
				this.view.setItems(items, true);
			},
			addEntity: function(item) {
				var id = ss.cast(item.__id, ss.Int32);
				if (ss.isNullOrUndefined(id)) {
					item.__id = this.$nextId++;
				}
				this.get_items().push(item);
				this.view.setItems(this.get_items(), true);
			},
			getNewEntity: function() {
				return ss.createInstance(TEntity);
			},
			getButtons: function() {
				var $t1 = [];
				$t1.push({ title: this.getAddButtonCaption(), cssClass: 'add-button', onClick: ss.mkdel(this, function() {
					this.createEntityDialog(this.getItemType(), ss.mkdel(this, function(dlg) {
						var dialog = ss.cast(dlg, ss.makeGenericType($NERP_Common_GridEditorDialog$1, [TEntity]));
						dialog.set_onSave(ss.mkdel(this, this.save));
						dialog.loadEntityAndOpenDialog(this.getNewEntity());
					}));
				}) });
				return $t1;
			},
			editItem: function(entityOrId) {
				var id = ss.unbox(Serenity.IdExtensions.toInt32(entityOrId));
				var item = this.view.getItemById(id);
				this.createEntityDialog(this.getItemType(), ss.mkdel(this, function(dlg) {
					var dialog = ss.cast(dlg, ss.makeGenericType($NERP_Common_GridEditorDialog$1, [TEntity]));
					dialog.set_onDelete(ss.mkdel(this, function(opt, callback) {
						if (!this.deleteEntity(id)) {
							return;
						}
						callback({});
					}));
					dialog.set_onSave(ss.mkdel(this, this.save));
					dialog.loadEntityAndOpenDialog(item);
				}));
			},
			getEditValue: function(property, target) {
				target[property.name] = this.get_value();
			},
			setEditValue: function(source, property) {
				this.set_value(ss.cast(source[property.name], Array));
			},
			get_value: function() {
				return Enumerable.from(this.view.getItems()).select(function(x) {
					var y = Q.deepClone(x);
					delete y['__id'];
					return y;
				}).toArray();
			},
			set_value: function(value) {
				this.view.setItems(Enumerable.from(value || []).select(ss.mkdel(this, function(x) {
					var y = Q.deepClone(x);
					y.__id = this.$nextId++;
					return y;
				})).toArray(), true);
			},
			getGridCanLoad: function() {
				return false;
			},
			usePager: function() {
				return false;
			},
			getInitialTitle: function() {
				return null;
			},
			createQuickSearchInput: function() {
			}
		}, function() {
			return ss.makeGenericType(Serenity.EntityGrid$1, [TEntity]);
		}, function() {
			return [Serenity.IDataGrid, Serenity.ISetEditValue, Serenity.IGetEditValue];
		});
		ss.setMetadata($type, { attr: [new Serenity.ElementAttribute('<div/>'), new Serenity.EditorAttribute(), new Serenity.IdPropertyAttribute('__id')] });
		return $type;
	};
	$NERP_Common_GridEditorBase$1.__typeName = 'NERP.Common.GridEditorBase$1';
	ss.initGenericClass($NERP_Common_GridEditorBase$1, $asm, 1);
	global.NERP.Common.GridEditorBase$1 = $NERP_Common_GridEditorBase$1;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Common.GridEditorDialog
	var $NERP_Common_GridEditorDialog$1 = function(TEntity) {
		var $type = function() {
			this.$8$OnSaveField = null;
			this.$8$OnDeleteField = null;
			ss.makeGenericType(Serenity.EntityDialog$1, [TEntity]).call(this);
		};
		ss.registerGenericClassInstance($type, $NERP_Common_GridEditorDialog$1, [TEntity], {
			destroy: function() {
				this.set_onSave(null);
				this.set_onDelete(null);
				ss.makeGenericType(Serenity.EntityDialog$2, [TEntity, Object]).prototype.destroy.call(this);
			},
			updateInterface: function() {
				ss.makeGenericType(Serenity.EntityDialog$2, [TEntity, Object]).prototype.updateInterface.call(this);
				// apply changes button doesn't work properly with in-memory grids yet
				if (ss.isValue(this.applyChangesButton)) {
					this.applyChangesButton.hide();
				}
			},
			saveHandler: function(options, callback) {
				if (!ss.staticEquals(this.get_onSave(), null)) {
					this.get_onSave()(options, callback);
				}
			},
			deleteHandler: function(options, callback) {
				if (!ss.staticEquals(this.get_onDelete(), null)) {
					this.get_onDelete()(options, callback);
				}
			},
			get_onSave: function() {
				return this.$8$OnSaveField;
			},
			set_onSave: function(value) {
				this.$8$OnSaveField = value;
			},
			get_onDelete: function() {
				return this.$8$OnDeleteField;
			},
			set_onDelete: function(value) {
				this.$8$OnDeleteField = value;
			}
		}, function() {
			return ss.makeGenericType(Serenity.EntityDialog$1, [TEntity]);
		}, function() {
			return [Serenity.IDialog, Serenity.IEditDialog];
		});
		ss.setMetadata($type, { attr: [new Serenity.IdPropertyAttribute('__id')] });
		return $type;
	};
	$NERP_Common_GridEditorDialog$1.__typeName = 'NERP.Common.GridEditorDialog$1';
	ss.initGenericClass($NERP_Common_GridEditorDialog$1, $asm, 1);
	global.NERP.Common.GridEditorDialog$1 = $NERP_Common_GridEditorDialog$1;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Common.LanguageSelection
	var $NERP_Common_LanguageSelection = function(select, currentLanguage) {
		Serenity.Widget.call(this, select);
		currentLanguage = ss.coalesce(currentLanguage, 'en');
		var self = this;
		Serenity.WX.change(this, function(e) {
			$.cookie('LanguagePreference', select.val(), { path: Q$Config.applicationPath });
			window.location.reload(true);
		});
		Q.getLookupAsync('Administration.Language').then(function(x) {
			if (!Enumerable.from(x.get_items()).any(function(z) {
				return ss.referenceEquals(z.LanguageId, currentLanguage);
			})) {
				var idx = currentLanguage.lastIndexOf('-');
				if (idx >= 0) {
					currentLanguage = currentLanguage.substr(0, idx);
					if (!Enumerable.from(x.get_items()).any(function(z1) {
						return ss.referenceEquals(z1.LanguageId, currentLanguage);
					})) {
						currentLanguage = 'en';
					}
				}
				else {
					currentLanguage = 'en';
				}
			}
			var $t1 = x.get_items();
			for (var $t2 = 0; $t2 < $t1.length; $t2++) {
				var l = $t1[$t2];
				Q.addOption(select, l.LanguageId, l.LanguageName);
			}
			select.val(currentLanguage);
		}, null);
	};
	$NERP_Common_LanguageSelection.__typeName = 'NERP.Common.LanguageSelection';
	global.NERP.Common.LanguageSelection = $NERP_Common_LanguageSelection;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Common.SidebarSearch
	var $NERP_Common_SidebarSearch = function(input, menuUL) {
		this.$menuUL = null;
		Serenity.Widget.call(this, input);
		var self = this;
		var $t1 = Serenity.QuickSearchInputOptions.$ctor();
		$t1.onSearch = function(field, text, success) {
			self.$updateMatchFlags(text);
			success(true);
		};
		new Serenity.QuickSearchInput(input, $t1);
		this.$menuUL = menuUL;
	};
	$NERP_Common_SidebarSearch.__typeName = 'NERP.Common.SidebarSearch';
	global.NERP.Common.SidebarSearch = $NERP_Common_SidebarSearch;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Common.ThemeSelection
	var $NERP_Common_ThemeSelection = function(select) {
		Serenity.Widget.call(this, select);
		var self = this;
		Serenity.WX.change(this, ss.mkdel(this, function(e) {
			$.cookie('ThemePreference', select.val(), { path: Q$Config.applicationPath });
			$('body').removeClass('skin-' + this.$getCurrentTheme());
			$('body').addClass('skin-' + select.val());
		}));
		Q.addOption(select, 'blue', Q.text('Site.Layout.ThemeBlue'));
		Q.addOption(select, 'blue-light', Q.text('Site.Layout.ThemeBlueLight'));
		Q.addOption(select, 'purple', Q.text('Site.Layout.ThemePurple'));
		Q.addOption(select, 'purple-light', Q.text('Site.Layout.ThemePurpleLight'));
		Q.addOption(select, 'red', Q.text('Site.Layout.ThemeRed'));
		Q.addOption(select, 'red-light', Q.text('Site.Layout.ThemeRedLight'));
		Q.addOption(select, 'green', Q.text('Site.Layout.ThemeGreen'));
		Q.addOption(select, 'green-light', Q.text('Site.Layout.ThemeGreenLight'));
		Q.addOption(select, 'yellow', Q.text('Site.Layout.ThemeYellow'));
		Q.addOption(select, 'yellow-light', Q.text('Site.Layout.ThemeYellowLight'));
		Q.addOption(select, 'black', Q.text('Site.Layout.ThemeBlack'));
		Q.addOption(select, 'black-light', Q.text('Site.Layout.ThemeBlackLight'));
		select.val(this.$getCurrentTheme());
	};
	$NERP_Common_ThemeSelection.__typeName = 'NERP.Common.ThemeSelection';
	global.NERP.Common.ThemeSelection = $NERP_Common_ThemeSelection;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.BrandDialog
	var $NERP_Configuration_BrandDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_BrandForm(this.get_idPrefix());
	};
	$NERP_Configuration_BrandDialog.__typeName = 'NERP.Configuration.BrandDialog';
	global.NERP.Configuration.BrandDialog = $NERP_Configuration_BrandDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.BrandForm
	var $NERP_Configuration_BrandForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_BrandForm.__typeName = 'NERP.Configuration.BrandForm';
	global.NERP.Configuration.BrandForm = $NERP_Configuration_BrandForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.BrandGrid
	var $NERP_Configuration_BrandGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_BrandGrid.__typeName = 'NERP.Configuration.BrandGrid';
	global.NERP.Configuration.BrandGrid = $NERP_Configuration_BrandGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ColorDialog
	var $NERP_Configuration_ColorDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_ColorForm(this.get_idPrefix());
	};
	$NERP_Configuration_ColorDialog.__typeName = 'NERP.Configuration.ColorDialog';
	global.NERP.Configuration.ColorDialog = $NERP_Configuration_ColorDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ColorForm
	var $NERP_Configuration_ColorForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_ColorForm.__typeName = 'NERP.Configuration.ColorForm';
	global.NERP.Configuration.ColorForm = $NERP_Configuration_ColorForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ColorGrid
	var $NERP_Configuration_ColorGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_ColorGrid.__typeName = 'NERP.Configuration.ColorGrid';
	global.NERP.Configuration.ColorGrid = $NERP_Configuration_ColorGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.CurrencyDialog
	var $NERP_Configuration_CurrencyDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_CurrencyForm(this.get_idPrefix());
	};
	$NERP_Configuration_CurrencyDialog.__typeName = 'NERP.Configuration.CurrencyDialog';
	global.NERP.Configuration.CurrencyDialog = $NERP_Configuration_CurrencyDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.CurrencyForm
	var $NERP_Configuration_CurrencyForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_CurrencyForm.__typeName = 'NERP.Configuration.CurrencyForm';
	global.NERP.Configuration.CurrencyForm = $NERP_Configuration_CurrencyForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.CurrencyGrid
	var $NERP_Configuration_CurrencyGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_CurrencyGrid.__typeName = 'NERP.Configuration.CurrencyGrid';
	global.NERP.Configuration.CurrencyGrid = $NERP_Configuration_CurrencyGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.GenericItemDialog
	var $NERP_Configuration_GenericItemDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_GenericItemForm(this.get_idPrefix());
	};
	$NERP_Configuration_GenericItemDialog.__typeName = 'NERP.Configuration.GenericItemDialog';
	global.NERP.Configuration.GenericItemDialog = $NERP_Configuration_GenericItemDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.GenericItemForm
	var $NERP_Configuration_GenericItemForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_GenericItemForm.__typeName = 'NERP.Configuration.GenericItemForm';
	global.NERP.Configuration.GenericItemForm = $NERP_Configuration_GenericItemForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.GenericItemGrid
	var $NERP_Configuration_GenericItemGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_GenericItemGrid.__typeName = 'NERP.Configuration.GenericItemGrid';
	global.NERP.Configuration.GenericItemGrid = $NERP_Configuration_GenericItemGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ItemCategoryDialog
	var $NERP_Configuration_ItemCategoryDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_ItemCategoryForm(this.get_idPrefix());
	};
	$NERP_Configuration_ItemCategoryDialog.__typeName = 'NERP.Configuration.ItemCategoryDialog';
	global.NERP.Configuration.ItemCategoryDialog = $NERP_Configuration_ItemCategoryDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ItemCategoryForm
	var $NERP_Configuration_ItemCategoryForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_ItemCategoryForm.__typeName = 'NERP.Configuration.ItemCategoryForm';
	global.NERP.Configuration.ItemCategoryForm = $NERP_Configuration_ItemCategoryForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ItemCategoryGrid
	var $NERP_Configuration_ItemCategoryGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_ItemCategoryGrid.__typeName = 'NERP.Configuration.ItemCategoryGrid';
	global.NERP.Configuration.ItemCategoryGrid = $NERP_Configuration_ItemCategoryGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ItemDialog
	var $NERP_Configuration_ItemDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_ItemForm(this.get_idPrefix());
	};
	$NERP_Configuration_ItemDialog.__typeName = 'NERP.Configuration.ItemDialog';
	global.NERP.Configuration.ItemDialog = $NERP_Configuration_ItemDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ItemForm
	var $NERP_Configuration_ItemForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_ItemForm.__typeName = 'NERP.Configuration.ItemForm';
	global.NERP.Configuration.ItemForm = $NERP_Configuration_ItemForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ItemGrid
	var $NERP_Configuration_ItemGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_ItemGrid.__typeName = 'NERP.Configuration.ItemGrid';
	global.NERP.Configuration.ItemGrid = $NERP_Configuration_ItemGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ItemTaxDialog
	var $NERP_Configuration_ItemTaxDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_ItemTaxForm(this.get_idPrefix());
	};
	$NERP_Configuration_ItemTaxDialog.__typeName = 'NERP.Configuration.ItemTaxDialog';
	global.NERP.Configuration.ItemTaxDialog = $NERP_Configuration_ItemTaxDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ItemTaxForm
	var $NERP_Configuration_ItemTaxForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_ItemTaxForm.__typeName = 'NERP.Configuration.ItemTaxForm';
	global.NERP.Configuration.ItemTaxForm = $NERP_Configuration_ItemTaxForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ItemTaxGrid
	var $NERP_Configuration_ItemTaxGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_ItemTaxGrid.__typeName = 'NERP.Configuration.ItemTaxGrid';
	global.NERP.Configuration.ItemTaxGrid = $NERP_Configuration_ItemTaxGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ModelDialog
	var $NERP_Configuration_ModelDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_ModelForm(this.get_idPrefix());
	};
	$NERP_Configuration_ModelDialog.__typeName = 'NERP.Configuration.ModelDialog';
	global.NERP.Configuration.ModelDialog = $NERP_Configuration_ModelDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ModelForm
	var $NERP_Configuration_ModelForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_ModelForm.__typeName = 'NERP.Configuration.ModelForm';
	global.NERP.Configuration.ModelForm = $NERP_Configuration_ModelForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ModelGrid
	var $NERP_Configuration_ModelGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_ModelGrid.__typeName = 'NERP.Configuration.ModelGrid';
	global.NERP.Configuration.ModelGrid = $NERP_Configuration_ModelGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.OrganogramDialog
	var $NERP_Configuration_OrganogramDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_OrganogramForm(this.get_idPrefix());
	};
	$NERP_Configuration_OrganogramDialog.__typeName = 'NERP.Configuration.OrganogramDialog';
	global.NERP.Configuration.OrganogramDialog = $NERP_Configuration_OrganogramDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.OrganogramForm
	var $NERP_Configuration_OrganogramForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_OrganogramForm.__typeName = 'NERP.Configuration.OrganogramForm';
	global.NERP.Configuration.OrganogramForm = $NERP_Configuration_OrganogramForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.OrganogramGrid
	var $NERP_Configuration_OrganogramGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_OrganogramGrid.__typeName = 'NERP.Configuration.OrganogramGrid';
	global.NERP.Configuration.OrganogramGrid = $NERP_Configuration_OrganogramGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.PaymentMethodDialog
	var $NERP_Configuration_PaymentMethodDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_PaymentMethodForm(this.get_idPrefix());
	};
	$NERP_Configuration_PaymentMethodDialog.__typeName = 'NERP.Configuration.PaymentMethodDialog';
	global.NERP.Configuration.PaymentMethodDialog = $NERP_Configuration_PaymentMethodDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.PaymentMethodForm
	var $NERP_Configuration_PaymentMethodForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_PaymentMethodForm.__typeName = 'NERP.Configuration.PaymentMethodForm';
	global.NERP.Configuration.PaymentMethodForm = $NERP_Configuration_PaymentMethodForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.PaymentMethodGrid
	var $NERP_Configuration_PaymentMethodGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_PaymentMethodGrid.__typeName = 'NERP.Configuration.PaymentMethodGrid';
	global.NERP.Configuration.PaymentMethodGrid = $NERP_Configuration_PaymentMethodGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ProjectDialog
	var $NERP_Configuration_ProjectDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_ProjectForm(this.get_idPrefix());
	};
	$NERP_Configuration_ProjectDialog.__typeName = 'NERP.Configuration.ProjectDialog';
	global.NERP.Configuration.ProjectDialog = $NERP_Configuration_ProjectDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ProjectForm
	var $NERP_Configuration_ProjectForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_ProjectForm.__typeName = 'NERP.Configuration.ProjectForm';
	global.NERP.Configuration.ProjectForm = $NERP_Configuration_ProjectForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.ProjectGrid
	var $NERP_Configuration_ProjectGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_ProjectGrid.__typeName = 'NERP.Configuration.ProjectGrid';
	global.NERP.Configuration.ProjectGrid = $NERP_Configuration_ProjectGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.SizeDialog
	var $NERP_Configuration_SizeDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_SizeForm(this.get_idPrefix());
	};
	$NERP_Configuration_SizeDialog.__typeName = 'NERP.Configuration.SizeDialog';
	global.NERP.Configuration.SizeDialog = $NERP_Configuration_SizeDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.SizeForm
	var $NERP_Configuration_SizeForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_SizeForm.__typeName = 'NERP.Configuration.SizeForm';
	global.NERP.Configuration.SizeForm = $NERP_Configuration_SizeForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.SizeGrid
	var $NERP_Configuration_SizeGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_SizeGrid.__typeName = 'NERP.Configuration.SizeGrid';
	global.NERP.Configuration.SizeGrid = $NERP_Configuration_SizeGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.SpecificationDialog
	var $NERP_Configuration_SpecificationDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_SpecificationForm(this.get_idPrefix());
	};
	$NERP_Configuration_SpecificationDialog.__typeName = 'NERP.Configuration.SpecificationDialog';
	global.NERP.Configuration.SpecificationDialog = $NERP_Configuration_SpecificationDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.SpecificationForm
	var $NERP_Configuration_SpecificationForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_SpecificationForm.__typeName = 'NERP.Configuration.SpecificationForm';
	global.NERP.Configuration.SpecificationForm = $NERP_Configuration_SpecificationForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.SpecificationGrid
	var $NERP_Configuration_SpecificationGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_SpecificationGrid.__typeName = 'NERP.Configuration.SpecificationGrid';
	global.NERP.Configuration.SpecificationGrid = $NERP_Configuration_SpecificationGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.StyleDialog
	var $NERP_Configuration_StyleDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_StyleForm(this.get_idPrefix());
	};
	$NERP_Configuration_StyleDialog.__typeName = 'NERP.Configuration.StyleDialog';
	global.NERP.Configuration.StyleDialog = $NERP_Configuration_StyleDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.StyleForm
	var $NERP_Configuration_StyleForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_StyleForm.__typeName = 'NERP.Configuration.StyleForm';
	global.NERP.Configuration.StyleForm = $NERP_Configuration_StyleForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.StyleGrid
	var $NERP_Configuration_StyleGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_StyleGrid.__typeName = 'NERP.Configuration.StyleGrid';
	global.NERP.Configuration.StyleGrid = $NERP_Configuration_StyleGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.TaxDialog
	var $NERP_Configuration_TaxDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_TaxForm(this.get_idPrefix());
	};
	$NERP_Configuration_TaxDialog.__typeName = 'NERP.Configuration.TaxDialog';
	global.NERP.Configuration.TaxDialog = $NERP_Configuration_TaxDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.TaxForm
	var $NERP_Configuration_TaxForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_TaxForm.__typeName = 'NERP.Configuration.TaxForm';
	global.NERP.Configuration.TaxForm = $NERP_Configuration_TaxForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.TaxGrid
	var $NERP_Configuration_TaxGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_TaxGrid.__typeName = 'NERP.Configuration.TaxGrid';
	global.NERP.Configuration.TaxGrid = $NERP_Configuration_TaxGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.UomDialog
	var $NERP_Configuration_UomDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Configuration_UomForm(this.get_idPrefix());
	};
	$NERP_Configuration_UomDialog.__typeName = 'NERP.Configuration.UomDialog';
	global.NERP.Configuration.UomDialog = $NERP_Configuration_UomDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.UomForm
	var $NERP_Configuration_UomForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Configuration_UomForm.__typeName = 'NERP.Configuration.UomForm';
	global.NERP.Configuration.UomForm = $NERP_Configuration_UomForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Configuration.UomGrid
	var $NERP_Configuration_UomGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Configuration_UomGrid.__typeName = 'NERP.Configuration.UomGrid';
	global.NERP.Configuration.UomGrid = $NERP_Configuration_UomGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.HR.EmployeeDialog
	var $NERP_HR_EmployeeDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_HR_EmployeeForm(this.get_idPrefix());
	};
	$NERP_HR_EmployeeDialog.__typeName = 'NERP.HR.EmployeeDialog';
	global.NERP.HR.EmployeeDialog = $NERP_HR_EmployeeDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.HR.EmployeeForm
	var $NERP_HR_EmployeeForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_HR_EmployeeForm.__typeName = 'NERP.HR.EmployeeForm';
	global.NERP.HR.EmployeeForm = $NERP_HR_EmployeeForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.HR.EmployeeGrid
	var $NERP_HR_EmployeeGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_HR_EmployeeGrid.__typeName = 'NERP.HR.EmployeeGrid';
	global.NERP.HR.EmployeeGrid = $NERP_HR_EmployeeGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Inventory.StockDialog
	var $NERP_Inventory_StockDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Inventory_StockForm(this.get_idPrefix());
	};
	$NERP_Inventory_StockDialog.__typeName = 'NERP.Inventory.StockDialog';
	global.NERP.Inventory.StockDialog = $NERP_Inventory_StockDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Inventory.StockForm
	var $NERP_Inventory_StockForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Inventory_StockForm.__typeName = 'NERP.Inventory.StockForm';
	global.NERP.Inventory.StockForm = $NERP_Inventory_StockForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Inventory.StockGrid
	var $NERP_Inventory_StockGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Inventory_StockGrid.__typeName = 'NERP.Inventory.StockGrid';
	global.NERP.Inventory.StockGrid = $NERP_Inventory_StockGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransDetailDialog
	var $NERP_ItemTransaction_TransDetailDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_ItemTransaction_TransDetailForm(this.get_idPrefix());
	};
	$NERP_ItemTransaction_TransDetailDialog.__typeName = 'NERP.ItemTransaction.TransDetailDialog';
	global.NERP.ItemTransaction.TransDetailDialog = $NERP_ItemTransaction_TransDetailDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransDetailEditDialog
	var $NERP_ItemTransaction_TransDetailEditDialog = function() {
		this.form = null;
		ss.makeGenericType($NERP_Common_GridEditorDialog$1, [Object]).call(this);
		this.form = new $NERP_ItemTransaction_TransDetailForm(this.get_idPrefix());
		Serenity.WX.change(this.form.get_quantity(), ss.mkdel(this, function(e) {
			this.form.get_amount().set_value(ss.Nullable$1.mul(this.form.get_quantity().get_value(), this.form.get_unitPrice().get_value()));
		}));
	};
	$NERP_ItemTransaction_TransDetailEditDialog.__typeName = 'NERP.ItemTransaction.TransDetailEditDialog';
	global.NERP.ItemTransaction.TransDetailEditDialog = $NERP_ItemTransaction_TransDetailEditDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransDetailEditor
	var $NERP_ItemTransaction_TransDetailEditor = function(container) {
		ss.makeGenericType($NERP_Common_GridEditorBase$1, [Object]).call(this, container);
	};
	$NERP_ItemTransaction_TransDetailEditor.__typeName = 'NERP.ItemTransaction.TransDetailEditor';
	global.NERP.ItemTransaction.TransDetailEditor = $NERP_ItemTransaction_TransDetailEditor;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransDetailForm
	var $NERP_ItemTransaction_TransDetailForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_ItemTransaction_TransDetailForm.__typeName = 'NERP.ItemTransaction.TransDetailForm';
	global.NERP.ItemTransaction.TransDetailForm = $NERP_ItemTransaction_TransDetailForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransDetailGrid
	var $NERP_ItemTransaction_TransDetailGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_ItemTransaction_TransDetailGrid.__typeName = 'NERP.ItemTransaction.TransDetailGrid';
	global.NERP.ItemTransaction.TransDetailGrid = $NERP_ItemTransaction_TransDetailGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransDialog
	var $NERP_ItemTransaction_TransDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_ItemTransaction_TransForm(this.get_idPrefix());
	};
	$NERP_ItemTransaction_TransDialog.__typeName = 'NERP.ItemTransaction.TransDialog';
	global.NERP.ItemTransaction.TransDialog = $NERP_ItemTransaction_TransDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransForm
	var $NERP_ItemTransaction_TransForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_ItemTransaction_TransForm.__typeName = 'NERP.ItemTransaction.TransForm';
	global.NERP.ItemTransaction.TransForm = $NERP_ItemTransaction_TransForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransGrid
	var $NERP_ItemTransaction_TransGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_ItemTransaction_TransGrid.__typeName = 'NERP.ItemTransaction.TransGrid';
	global.NERP.ItemTransaction.TransGrid = $NERP_ItemTransaction_TransGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransPaymentDialog
	var $NERP_ItemTransaction_TransPaymentDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_ItemTransaction_TransPaymentForm(this.get_idPrefix());
	};
	$NERP_ItemTransaction_TransPaymentDialog.__typeName = 'NERP.ItemTransaction.TransPaymentDialog';
	global.NERP.ItemTransaction.TransPaymentDialog = $NERP_ItemTransaction_TransPaymentDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransPaymentForm
	var $NERP_ItemTransaction_TransPaymentForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_ItemTransaction_TransPaymentForm.__typeName = 'NERP.ItemTransaction.TransPaymentForm';
	global.NERP.ItemTransaction.TransPaymentForm = $NERP_ItemTransaction_TransPaymentForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransPaymentGrid
	var $NERP_ItemTransaction_TransPaymentGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_ItemTransaction_TransPaymentGrid.__typeName = 'NERP.ItemTransaction.TransPaymentGrid';
	global.NERP.ItemTransaction.TransPaymentGrid = $NERP_ItemTransaction_TransPaymentGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransTaxDialog
	var $NERP_ItemTransaction_TransTaxDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_ItemTransaction_TransTaxForm(this.get_idPrefix());
	};
	$NERP_ItemTransaction_TransTaxDialog.__typeName = 'NERP.ItemTransaction.TransTaxDialog';
	global.NERP.ItemTransaction.TransTaxDialog = $NERP_ItemTransaction_TransTaxDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransTaxForm
	var $NERP_ItemTransaction_TransTaxForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_ItemTransaction_TransTaxForm.__typeName = 'NERP.ItemTransaction.TransTaxForm';
	global.NERP.ItemTransaction.TransTaxForm = $NERP_ItemTransaction_TransTaxForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.ItemTransaction.TransTaxGrid
	var $NERP_ItemTransaction_TransTaxGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_ItemTransaction_TransTaxGrid.__typeName = 'NERP.ItemTransaction.TransTaxGrid';
	global.NERP.ItemTransaction.TransTaxGrid = $NERP_ItemTransaction_TransTaxGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Membership.ChangePasswordForm
	var $NERP_Membership_ChangePasswordForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Membership_ChangePasswordForm.__typeName = 'NERP.Membership.ChangePasswordForm';
	global.NERP.Membership.ChangePasswordForm = $NERP_Membership_ChangePasswordForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Membership.ChangePasswordPanel
	var $NERP_Membership_ChangePasswordPanel = function(container) {
		this.$form = null;
		ss.makeGenericType(Serenity.PropertyPanel$1, [Object]).call(this, container);
		this.$form = new $NERP_Membership_ChangePasswordForm(this.get_idPrefix());
		Serenity.VX.addValidationRule(this.$form.get_newPassword(), this.get_uniqueName(), ss.mkdel(this, function(e) {
			if (this.$form.get_confirmPassword().get_value().length < 7) {
				return ss.formatString(Q.text('Validation.MinRequiredPasswordLength'), 7);
			}
			return null;
		}));
		Serenity.VX.addValidationRule(this.$form.get_confirmPassword(), this.get_uniqueName(), ss.mkdel(this, function(e1) {
			if (!ss.referenceEquals(this.$form.get_confirmPassword().get_value(), this.$form.get_newPassword().get_value())) {
				return Q.text('Validation.PasswordConfirm');
			}
			return null;
		}));
		this.byId$1('SubmitButton').click(ss.thisFix(ss.mkdel(this, function(s, e2) {
			e2.preventDefault();
			if (!this.validateForm()) {
				return;
			}
			var request = this.getSaveEntity();
			Q.serviceCall({
				url: Q.resolveUrl('~/Account/ChangePassword'),
				request: request,
				onSuccess: function(response) {
					Q.information(Q.text('Forms.Membership.ChangePassword.Success'), function() {
						window.location.href = Q.resolveUrl('~/');
					}, {});
				}
			});
		})));
	};
	$NERP_Membership_ChangePasswordPanel.__typeName = 'NERP.Membership.ChangePasswordPanel';
	global.NERP.Membership.ChangePasswordPanel = $NERP_Membership_ChangePasswordPanel;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Membership.ForgotPasswordForm
	var $NERP_Membership_ForgotPasswordForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Membership_ForgotPasswordForm.__typeName = 'NERP.Membership.ForgotPasswordForm';
	global.NERP.Membership.ForgotPasswordForm = $NERP_Membership_ForgotPasswordForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Membership.ForgotPasswordPanel
	var $NERP_Membership_ForgotPasswordPanel = function(container) {
		ss.makeGenericType(Serenity.PropertyPanel$1, [Object]).call(this, container);
		this.byId$1('SubmitButton').click(ss.thisFix(ss.mkdel(this, function(s, e) {
			e.preventDefault();
			if (!this.validateForm()) {
				return;
			}
			var request = this.getSaveEntity();
			Q.serviceCall({
				url: Q.resolveUrl('~/Account/ForgotPassword'),
				request: request,
				onSuccess: function(response) {
					Q.information(Q.text('Forms.Membership.ForgotPassword.Success'), function() {
						window.location.href = Q.resolveUrl('~/');
					}, {});
				}
			});
		})));
	};
	$NERP_Membership_ForgotPasswordPanel.__typeName = 'NERP.Membership.ForgotPasswordPanel';
	global.NERP.Membership.ForgotPasswordPanel = $NERP_Membership_ForgotPasswordPanel;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Membership.LoginForm
	var $NERP_Membership_LoginForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Membership_LoginForm.__typeName = 'NERP.Membership.LoginForm';
	global.NERP.Membership.LoginForm = $NERP_Membership_LoginForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Membership.LoginPanel
	var $NERP_Membership_LoginPanel = function(container) {
		ss.makeGenericType(Serenity.PropertyPanel$1, [Object]).call(this, container);
		this.byId$1('LoginButton').click(ss.thisFix(ss.mkdel(this, function(s, e) {
			e.preventDefault();
			if (!this.validateForm()) {
				return;
			}
			var request = this.getSaveEntity();
			Q.serviceCall({
				url: Q.resolveUrl('~/Account/Login'),
				request: request,
				onSuccess: function(response) {
					var q = Q.parseQueryString();
					var $t1 = q['returnUrl'];
					if (ss.isNullOrUndefined($t1)) {
						$t1 = q['ReturnUrl'];
					}
					var r = $t1;
					if (!ss.isNullOrEmptyString(r)) {
						window.location.href = r;
					}
					else {
						window.location.href = Q.resolveUrl('~/');
					}
				}
			});
		})));
	};
	$NERP_Membership_LoginPanel.__typeName = 'NERP.Membership.LoginPanel';
	global.NERP.Membership.LoginPanel = $NERP_Membership_LoginPanel;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Membership.ResetPasswordForm
	var $NERP_Membership_ResetPasswordForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Membership_ResetPasswordForm.__typeName = 'NERP.Membership.ResetPasswordForm';
	global.NERP.Membership.ResetPasswordForm = $NERP_Membership_ResetPasswordForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Membership.ResetPasswordPanel
	var $NERP_Membership_ResetPasswordPanel = function(container) {
		this.$form = null;
		ss.makeGenericType(Serenity.PropertyPanel$1, [Object]).call(this, container);
		this.$form = new $NERP_Membership_ResetPasswordForm(this.get_idPrefix());
		Serenity.VX.addValidationRule(this.$form.get_newPassword(), this.get_uniqueName(), ss.mkdel(this, function(e) {
			if (this.$form.get_confirmPassword().get_value().length < 7) {
				return ss.formatString(Q.text('Validation.MinRequiredPasswordLength'), 7);
			}
			return null;
		}));
		Serenity.VX.addValidationRule(this.$form.get_confirmPassword(), this.get_uniqueName(), ss.mkdel(this, function(e1) {
			if (!ss.referenceEquals(this.$form.get_confirmPassword().get_value(), this.$form.get_newPassword().get_value())) {
				return Q.text('Validation.PasswordConfirm');
			}
			return null;
		}));
		this.byId$1('SubmitButton').click(ss.thisFix(ss.mkdel(this, function(s, e2) {
			e2.preventDefault();
			if (!this.validateForm()) {
				return;
			}
			var request = this.getSaveEntity();
			request.Token = this.byId$1('Token').val();
			Q.serviceCall({
				url: Q.resolveUrl('~/Account/ResetPassword'),
				request: request,
				onSuccess: function(response) {
					Q.information(Q.text('Forms.Membership.ResetPassword.Success'), function() {
						window.location.href = Q.resolveUrl('~/Account/Login');
					}, {});
				}
			});
		})));
	};
	$NERP_Membership_ResetPasswordPanel.__typeName = 'NERP.Membership.ResetPasswordPanel';
	global.NERP.Membership.ResetPasswordPanel = $NERP_Membership_ResetPasswordPanel;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Membership.SignUpForm
	var $NERP_Membership_SignUpForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Membership_SignUpForm.__typeName = 'NERP.Membership.SignUpForm';
	global.NERP.Membership.SignUpForm = $NERP_Membership_SignUpForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Membership.SignUpPanel
	var $NERP_Membership_SignUpPanel = function(container) {
		this.$form = null;
		ss.makeGenericType(Serenity.PropertyPanel$1, [Object]).call(this, container);
		this.$form = new $NERP_Membership_SignUpForm(this.get_idPrefix());
		Serenity.VX.addValidationRule(this.$form.get_confirmPassword(), this.uniqueName, ss.mkdel(this, function(e) {
			if (!ss.referenceEquals(this.$form.get_confirmPassword().get_value(), this.$form.get_password().get_value())) {
				return Q.text('Validation.PasswordConfirm');
			}
			return null;
		}));
		Serenity.VX.addValidationRule(this.$form.get_confirmEmail(), this.uniqueName, ss.mkdel(this, function(e1) {
			if (!ss.referenceEquals(this.$form.get_confirmEmail().get_value(), this.$form.get_email().get_value())) {
				return Q.text('Validation.EmailConfirm');
			}
			return null;
		}));
		this.byId$1('SubmitButton').click(ss.thisFix(ss.mkdel(this, function(s, e2) {
			e2.preventDefault();
			if (!this.validateForm()) {
				return;
			}
			Q.serviceCall({
				url: Q.resolveUrl('~/Account/SignUp'),
				request: { DisplayName: this.$form.get_displayName().get_value(), Email: this.$form.get_email().get_value(), Password: this.$form.get_password().get_value() },
				onSuccess: function(response) {
					Q.information(Q.text('Forms.Membership.SignUp.Success'), function() {
						window.location.href = Q.resolveUrl('~/');
					}, {});
				}
			});
		})));
	};
	$NERP_Membership_SignUpPanel.__typeName = 'NERP.Membership.SignUpPanel';
	global.NERP.Membership.SignUpPanel = $NERP_Membership_SignUpPanel;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CategoryDialog
	var $NERP_Northwind_CategoryDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$NERP_Northwind_CategoryDialog.__typeName = 'NERP.Northwind.CategoryDialog';
	global.NERP.Northwind.CategoryDialog = $NERP_Northwind_CategoryDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CategoryForm
	var $NERP_Northwind_CategoryForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Northwind_CategoryForm.__typeName = 'NERP.Northwind.CategoryForm';
	global.NERP.Northwind.CategoryForm = $NERP_Northwind_CategoryForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CategoryGrid
	var $NERP_Northwind_CategoryGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Northwind_CategoryGrid.__typeName = 'NERP.Northwind.CategoryGrid';
	global.NERP.Northwind.CategoryGrid = $NERP_Northwind_CategoryGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CustomerCustomerDemoDialog
	var $NERP_Northwind_CustomerCustomerDemoDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$NERP_Northwind_CustomerCustomerDemoDialog.__typeName = 'NERP.Northwind.CustomerCustomerDemoDialog';
	global.NERP.Northwind.CustomerCustomerDemoDialog = $NERP_Northwind_CustomerCustomerDemoDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CustomerCustomerDemoForm
	var $NERP_Northwind_CustomerCustomerDemoForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Northwind_CustomerCustomerDemoForm.__typeName = 'NERP.Northwind.CustomerCustomerDemoForm';
	global.NERP.Northwind.CustomerCustomerDemoForm = $NERP_Northwind_CustomerCustomerDemoForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CustomerCustomerDemoGrid
	var $NERP_Northwind_CustomerCustomerDemoGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Northwind_CustomerCustomerDemoGrid.__typeName = 'NERP.Northwind.CustomerCustomerDemoGrid';
	global.NERP.Northwind.CustomerCustomerDemoGrid = $NERP_Northwind_CustomerCustomerDemoGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CustomerDemographicDialog
	var $NERP_Northwind_CustomerDemographicDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$NERP_Northwind_CustomerDemographicDialog.__typeName = 'NERP.Northwind.CustomerDemographicDialog';
	global.NERP.Northwind.CustomerDemographicDialog = $NERP_Northwind_CustomerDemographicDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CustomerDemographicForm
	var $NERP_Northwind_CustomerDemographicForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Northwind_CustomerDemographicForm.__typeName = 'NERP.Northwind.CustomerDemographicForm';
	global.NERP.Northwind.CustomerDemographicForm = $NERP_Northwind_CustomerDemographicForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CustomerDemographicGrid
	var $NERP_Northwind_CustomerDemographicGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Northwind_CustomerDemographicGrid.__typeName = 'NERP.Northwind.CustomerDemographicGrid';
	global.NERP.Northwind.CustomerDemographicGrid = $NERP_Northwind_CustomerDemographicGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CustomerDialog
	var $NERP_Northwind_CustomerDialog = function() {
		this.$ordersGrid = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.$ordersGrid = new $NERP_Northwind_CustomerOrdersGrid(this.byId$1('OrdersGrid'));
		Serenity.FLX.flexHeightOnly(this.$ordersGrid.get_element(), 1);
		this.byId$1('NoteList').closest('.field').hide().end().appendTo(this.byId$1('TabNotes'));
		this.tabs.bind('tabsactivate', ss.mkdel(this, function(e, i) {
			this.arrange();
		}));
	};
	$NERP_Northwind_CustomerDialog.__typeName = 'NERP.Northwind.CustomerDialog';
	global.NERP.Northwind.CustomerDialog = $NERP_Northwind_CustomerDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CustomerEditor
	var $NERP_Northwind_CustomerEditor = function(container, options) {
		ss.makeGenericType(Serenity.LookupEditorBase$1, [Object]).$ctor1.call(this, container, options);
	};
	$NERP_Northwind_CustomerEditor.__typeName = 'NERP.Northwind.CustomerEditor';
	global.NERP.Northwind.CustomerEditor = $NERP_Northwind_CustomerEditor;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CustomerForm
	var $NERP_Northwind_CustomerForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Northwind_CustomerForm.__typeName = 'NERP.Northwind.CustomerForm';
	global.NERP.Northwind.CustomerForm = $NERP_Northwind_CustomerForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CustomerGrid
	var $NERP_Northwind_CustomerGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Northwind_CustomerGrid.__typeName = 'NERP.Northwind.CustomerGrid';
	global.NERP.Northwind.CustomerGrid = $NERP_Northwind_CustomerGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CustomerOrderDialog
	var $NERP_Northwind_CustomerOrderDialog = function() {
		$NERP_Northwind_OrderDialog.call(this);
	};
	$NERP_Northwind_CustomerOrderDialog.__typeName = 'NERP.Northwind.CustomerOrderDialog';
	global.NERP.Northwind.CustomerOrderDialog = $NERP_Northwind_CustomerOrderDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.CustomerOrdersGrid
	var $NERP_Northwind_CustomerOrdersGrid = function(container) {
		this.$customerID = null;
		$NERP_Northwind_OrderGrid.call(this, container);
	};
	$NERP_Northwind_CustomerOrdersGrid.__typeName = 'NERP.Northwind.CustomerOrdersGrid';
	global.NERP.Northwind.CustomerOrdersGrid = $NERP_Northwind_CustomerOrdersGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.EmployeeDialog
	var $NERP_Northwind_EmployeeDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$NERP_Northwind_EmployeeDialog.__typeName = 'NERP.Northwind.EmployeeDialog';
	global.NERP.Northwind.EmployeeDialog = $NERP_Northwind_EmployeeDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.EmployeeForm
	var $NERP_Northwind_EmployeeForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Northwind_EmployeeForm.__typeName = 'NERP.Northwind.EmployeeForm';
	global.NERP.Northwind.EmployeeForm = $NERP_Northwind_EmployeeForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.EmployeeFormatter
	var $NERP_Northwind_EmployeeFormatter = function() {
		this.$1$GenderPropertyField = null;
	};
	$NERP_Northwind_EmployeeFormatter.__typeName = 'NERP.Northwind.EmployeeFormatter';
	global.NERP.Northwind.EmployeeFormatter = $NERP_Northwind_EmployeeFormatter;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.EmployeeGrid
	var $NERP_Northwind_EmployeeGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Northwind_EmployeeGrid.__typeName = 'NERP.Northwind.EmployeeGrid';
	global.NERP.Northwind.EmployeeGrid = $NERP_Northwind_EmployeeGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.EmployeeTerritoryDialog
	var $NERP_Northwind_EmployeeTerritoryDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$NERP_Northwind_EmployeeTerritoryDialog.__typeName = 'NERP.Northwind.EmployeeTerritoryDialog';
	global.NERP.Northwind.EmployeeTerritoryDialog = $NERP_Northwind_EmployeeTerritoryDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.EmployeeTerritoryForm
	var $NERP_Northwind_EmployeeTerritoryForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Northwind_EmployeeTerritoryForm.__typeName = 'NERP.Northwind.EmployeeTerritoryForm';
	global.NERP.Northwind.EmployeeTerritoryForm = $NERP_Northwind_EmployeeTerritoryForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.EmployeeTerritoryGrid
	var $NERP_Northwind_EmployeeTerritoryGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Northwind_EmployeeTerritoryGrid.__typeName = 'NERP.Northwind.EmployeeTerritoryGrid';
	global.NERP.Northwind.EmployeeTerritoryGrid = $NERP_Northwind_EmployeeTerritoryGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.FreightFormatter
	var $NERP_Northwind_FreightFormatter = function() {
	};
	$NERP_Northwind_FreightFormatter.__typeName = 'NERP.Northwind.FreightFormatter';
	global.NERP.Northwind.FreightFormatter = $NERP_Northwind_FreightFormatter;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.Gender
	var $NERP_Northwind_Gender = function() {
	};
	$NERP_Northwind_Gender.__typeName = 'NERP.Northwind.Gender';
	global.NERP.Northwind.Gender = $NERP_Northwind_Gender;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.NoteDialog
	var $NERP_Northwind_NoteDialog = function() {
		this.okClick = null;
		Serenity.TemplatedDialog.call(this);
		var $t2 = this.byId$1('Text');
		var $t1 = Serenity.HtmlContentEditorOptions.$ctor();
		$t1.rows = 12;
		new $Serenity_HtmlBasicContentEditor($t2, $t1);
	};
	$NERP_Northwind_NoteDialog.__typeName = 'NERP.Northwind.NoteDialog';
	global.NERP.Northwind.NoteDialog = $NERP_Northwind_NoteDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.NotesEditor
	var $NERP_Northwind_NotesEditor = function(container) {
		this.$items = null;
		this.$6$IsDirtyField = false;
		this.$6$OnChangeField = null;
		Serenity.TemplatedWidget.call(this, container);
		var $t2 = this.byId$1('Toolbar');
		var $t1 = [];
		$t1.push({ title: 'Add Note', cssClass: 'add-button', onClick: ss.mkdel(this, function(e) {
			e.preventDefault();
			this.$addClick();
		}) });
		new Serenity.Toolbar($t2, { buttons: $t1 });
	};
	$NERP_Northwind_NotesEditor.__typeName = 'NERP.Northwind.NotesEditor';
	global.NERP.Northwind.NotesEditor = $NERP_Northwind_NotesEditor;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.OrderDetailDialog
	var $NERP_Northwind_OrderDetailDialog = function() {
		this.$form = null;
		ss.makeGenericType($NERP_Common_GridEditorDialog$1, [Object]).call(this);
		this.$form = new $NERP_Northwind_OrderDetailForm(this.get_idPrefix());
		Serenity.WX.changeSelect2(this.$form.get_productID(), ss.mkdel(this, function(e) {
			var productID = Serenity.IdExtensions.toInt32(this.$form.get_productID().get_value());
			if (ss.isValue(productID)) {
				this.$form.get_unitPrice().set_value(Q.getLookup('Northwind.Product').get_itemById()[ss.unbox(productID)].UnitPrice);
			}
		}));
		Serenity.VX.addValidationRule(this.$form.get_discount(), this.uniqueName, ss.mkdel(this, function(e1) {
			if (ss.isValue(this.$form.get_unitPrice().get_value()) && ss.isValue(this.$form.get_quantity().get_value$1()) && ss.isValue(this.$form.get_discount().get_value()) && ss.unbox(this.$form.get_discount().get_value()) > 0 && ss.unbox(this.$form.get_discount().get_value()) > ss.unbox(this.$form.get_unitPrice().get_value()) * ss.unbox(this.$form.get_quantity().get_value$1())) {
				return "Discount can't be higher than total price!";
			}
			return null;
		}));
	};
	$NERP_Northwind_OrderDetailDialog.__typeName = 'NERP.Northwind.OrderDetailDialog';
	global.NERP.Northwind.OrderDetailDialog = $NERP_Northwind_OrderDetailDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.OrderDetailForm
	var $NERP_Northwind_OrderDetailForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Northwind_OrderDetailForm.__typeName = 'NERP.Northwind.OrderDetailForm';
	global.NERP.Northwind.OrderDetailForm = $NERP_Northwind_OrderDetailForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.OrderDetailsEditor
	var $NERP_Northwind_OrderDetailsEditor = function(container) {
		ss.makeGenericType($NERP_Common_GridEditorBase$1, [Object]).call(this, container);
	};
	$NERP_Northwind_OrderDetailsEditor.__typeName = 'NERP.Northwind.OrderDetailsEditor';
	global.NERP.Northwind.OrderDetailsEditor = $NERP_Northwind_OrderDetailsEditor;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.OrderDialog
	var $NERP_Northwind_OrderDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Northwind_OrderForm(this.get_idPrefix());
	};
	$NERP_Northwind_OrderDialog.__typeName = 'NERP.Northwind.OrderDialog';
	global.NERP.Northwind.OrderDialog = $NERP_Northwind_OrderDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.OrderForm
	var $NERP_Northwind_OrderForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Northwind_OrderForm.__typeName = 'NERP.Northwind.OrderForm';
	global.NERP.Northwind.OrderForm = $NERP_Northwind_OrderForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.OrderGrid
	var $NERP_Northwind_OrderGrid = function(container) {
		this.$shippingState = null;
		this.$7$CustomerFilterField = null;
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Northwind_OrderGrid.__typeName = 'NERP.Northwind.OrderGrid';
	global.NERP.Northwind.OrderGrid = $NERP_Northwind_OrderGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.OrderShippingState
	var $NERP_Northwind_OrderShippingState = function() {
	};
	$NERP_Northwind_OrderShippingState.__typeName = 'NERP.Northwind.OrderShippingState';
	global.NERP.Northwind.OrderShippingState = $NERP_Northwind_OrderShippingState;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.PhoneEditor
	var $NERP_Northwind_PhoneEditor = function(input) {
		this.$5$MultipleField = false;
		Serenity.StringEditor.call(this, input);
		Serenity.VX.addValidationRule(this, this.uniqueName, ss.mkdel(this, function(e) {
			var value = Q.trimToNull(this.get_value());
			if (ss.isNullOrUndefined(value)) {
				return null;
			}
			return $NERP_Northwind_PhoneEditor.$validate(value, this.get_multiple());
		}));
		input.bind('change', ss.mkdel(this, function(e1) {
			if (!Serenity.WX.hasOriginalEvent(e1)) {
				return;
			}
			this.formatValue();
		}));
		input.bind('blur', ss.mkdel(this, function(e2) {
			if (this.element.hasClass('valid')) {
				this.formatValue();
			}
		}));
	};
	$NERP_Northwind_PhoneEditor.__typeName = 'NERP.Northwind.PhoneEditor';
	$NERP_Northwind_PhoneEditor.$validate = function(phone, isMultiple) {
		var valid = (isMultiple ? $NERP_Northwind_PhoneEditor.$isValidMulti(phone, $NERP_Northwind_PhoneEditor.$isValidPhone) : $NERP_Northwind_PhoneEditor.$isValidPhone(phone));
		if (valid) {
			return null;
		}
		return Q.text((isMultiple ? 'Validation.NorthwindPhoneMultiple' : 'Validation.NorthwindPhone'));
	};
	$NERP_Northwind_PhoneEditor.$isValidPhone = function(phone) {
		if (Q.isEmptyOrNull(phone)) {
			return false;
		}
		phone = ss.replaceAllString(ss.replaceAllString(phone, ' ', ''), '-', '');
		if (phone.length < 10) {
			return false;
		}
		if (ss.startsWithString(phone, '0')) {
			phone = phone.substring(1);
		}
		if (ss.startsWithString(phone, '(') && phone.charCodeAt(4) === 41) {
			phone = phone.substr(1, 3) + phone.substring(5);
		}
		if (phone.length !== 10) {
			return false;
		}
		if (ss.startsWithString(phone, '0')) {
			return false;
		}
		for (var i = 0; i < phone.length; i++) {
			var c = phone.charCodeAt(i);
			if (c < 48 || c > 57) {
				return false;
			}
		}
		return true;
	};
	$NERP_Northwind_PhoneEditor.$formatPhone = function(phone) {
		if (!$NERP_Northwind_PhoneEditor.$isValidPhone(phone)) {
			return phone;
		}
		phone = ss.replaceAllString(ss.replaceAllString(ss.replaceAllString(ss.replaceAllString(phone, ' ', ''), '-', ''), '(', ''), ')', '');
		if (ss.startsWithString(phone, '0')) {
			phone = phone.substring(1);
		}
		phone = '(' + phone.substr(0, 3) + ') ' + phone.substr(3, 3) + '-' + phone.substr(6, 2) + phone.substr(8, 2);
		return phone;
	};
	$NERP_Northwind_PhoneEditor.$formatMulti = function(phone, format) {
		var phones = ss.replaceAllString(phone, String.fromCharCode(59), String.fromCharCode(44)).split(String.fromCharCode(44));
		var result = '';
		for (var $t1 = 0; $t1 < phones.length; $t1++) {
			var x = phones[$t1];
			var s = Q.trimToNull(x);
			if (ss.isNullOrUndefined(s)) {
				continue;
			}
			if (result.length > 0) {
				result += ', ';
			}
			result += format(s);
		}
		return result;
	};
	$NERP_Northwind_PhoneEditor.$isValidMulti = function(phone, check) {
		if (Q.isEmptyOrNull(phone)) {
			return false;
		}
		var phones = ss.replaceAllString(phone, String.fromCharCode(59), String.fromCharCode(44)).split(String.fromCharCode(44));
		var anyValid = false;
		for (var $t1 = 0; $t1 < phones.length; $t1++) {
			var x = phones[$t1];
			var s = Q.trimToNull(x);
			if (ss.isNullOrUndefined(s)) {
				continue;
			}
			if (!check(s)) {
				return false;
			}
			anyValid = true;
		}
		if (!anyValid) {
			return false;
		}
		return true;
	};
	global.NERP.Northwind.PhoneEditor = $NERP_Northwind_PhoneEditor;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.ProductDialog
	var $NERP_Northwind_ProductDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$NERP_Northwind_ProductDialog.__typeName = 'NERP.Northwind.ProductDialog';
	global.NERP.Northwind.ProductDialog = $NERP_Northwind_ProductDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.ProductForm
	var $NERP_Northwind_ProductForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Northwind_ProductForm.__typeName = 'NERP.Northwind.ProductForm';
	global.NERP.Northwind.ProductForm = $NERP_Northwind_ProductForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.ProductGrid
	var $NERP_Northwind_ProductGrid = function(container) {
		this.$pendingChanges = {};
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
		this.slickContainer.on('change', 'input.edit', ss.mkdel(this, this.$inputsChange));
	};
	$NERP_Northwind_ProductGrid.__typeName = 'NERP.Northwind.ProductGrid';
	global.NERP.Northwind.ProductGrid = $NERP_Northwind_ProductGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.RegionDialog
	var $NERP_Northwind_RegionDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$NERP_Northwind_RegionDialog.__typeName = 'NERP.Northwind.RegionDialog';
	global.NERP.Northwind.RegionDialog = $NERP_Northwind_RegionDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.RegionForm
	var $NERP_Northwind_RegionForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Northwind_RegionForm.__typeName = 'NERP.Northwind.RegionForm';
	global.NERP.Northwind.RegionForm = $NERP_Northwind_RegionForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.RegionGrid
	var $NERP_Northwind_RegionGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Northwind_RegionGrid.__typeName = 'NERP.Northwind.RegionGrid';
	global.NERP.Northwind.RegionGrid = $NERP_Northwind_RegionGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.ShipperDialog
	var $NERP_Northwind_ShipperDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$NERP_Northwind_ShipperDialog.__typeName = 'NERP.Northwind.ShipperDialog';
	global.NERP.Northwind.ShipperDialog = $NERP_Northwind_ShipperDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.ShipperForm
	var $NERP_Northwind_ShipperForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Northwind_ShipperForm.__typeName = 'NERP.Northwind.ShipperForm';
	global.NERP.Northwind.ShipperForm = $NERP_Northwind_ShipperForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.ShipperFormatter
	var $NERP_Northwind_ShipperFormatter = function() {
	};
	$NERP_Northwind_ShipperFormatter.__typeName = 'NERP.Northwind.ShipperFormatter';
	global.NERP.Northwind.ShipperFormatter = $NERP_Northwind_ShipperFormatter;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.ShipperGrid
	var $NERP_Northwind_ShipperGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Northwind_ShipperGrid.__typeName = 'NERP.Northwind.ShipperGrid';
	global.NERP.Northwind.ShipperGrid = $NERP_Northwind_ShipperGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.SupplierDialog
	var $NERP_Northwind_SupplierDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$NERP_Northwind_SupplierDialog.__typeName = 'NERP.Northwind.SupplierDialog';
	global.NERP.Northwind.SupplierDialog = $NERP_Northwind_SupplierDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.SupplierForm
	var $NERP_Northwind_SupplierForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Northwind_SupplierForm.__typeName = 'NERP.Northwind.SupplierForm';
	global.NERP.Northwind.SupplierForm = $NERP_Northwind_SupplierForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.SupplierGrid
	var $NERP_Northwind_SupplierGrid = function(container) {
		this.$country = null;
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Northwind_SupplierGrid.__typeName = 'NERP.Northwind.SupplierGrid';
	global.NERP.Northwind.SupplierGrid = $NERP_Northwind_SupplierGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.TerritoryDialog
	var $NERP_Northwind_TerritoryDialog = function() {
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
	};
	$NERP_Northwind_TerritoryDialog.__typeName = 'NERP.Northwind.TerritoryDialog';
	global.NERP.Northwind.TerritoryDialog = $NERP_Northwind_TerritoryDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.TerritoryForm
	var $NERP_Northwind_TerritoryForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Northwind_TerritoryForm.__typeName = 'NERP.Northwind.TerritoryForm';
	global.NERP.Northwind.TerritoryForm = $NERP_Northwind_TerritoryForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Northwind.TerritoryGrid
	var $NERP_Northwind_TerritoryGrid = function(container) {
		this.$region = null;
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Northwind_TerritoryGrid.__typeName = 'NERP.Northwind.TerritoryGrid';
	global.NERP.Northwind.TerritoryGrid = $NERP_Northwind_TerritoryGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Purchase.SupplierDialog
	var $NERP_Purchase_SupplierDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Purchase_SupplierForm(this.get_idPrefix());
	};
	$NERP_Purchase_SupplierDialog.__typeName = 'NERP.Purchase.SupplierDialog';
	global.NERP.Purchase.SupplierDialog = $NERP_Purchase_SupplierDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Purchase.SupplierForm
	var $NERP_Purchase_SupplierForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Purchase_SupplierForm.__typeName = 'NERP.Purchase.SupplierForm';
	global.NERP.Purchase.SupplierForm = $NERP_Purchase_SupplierForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Purchase.SupplierGrid
	var $NERP_Purchase_SupplierGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Purchase_SupplierGrid.__typeName = 'NERP.Purchase.SupplierGrid';
	global.NERP.Purchase.SupplierGrid = $NERP_Purchase_SupplierGrid;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Sales.CustomerDialog
	var $NERP_Sales_CustomerDialog = function() {
		this.form = null;
		ss.makeGenericType(Serenity.EntityDialog$1, [Object]).call(this);
		this.form = new $NERP_Sales_CustomerForm(this.get_idPrefix());
	};
	$NERP_Sales_CustomerDialog.__typeName = 'NERP.Sales.CustomerDialog';
	global.NERP.Sales.CustomerDialog = $NERP_Sales_CustomerDialog;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Sales.CustomerForm
	var $NERP_Sales_CustomerForm = function(idPrefix) {
		Serenity.PrefixedContext.call(this, idPrefix);
	};
	$NERP_Sales_CustomerForm.__typeName = 'NERP.Sales.CustomerForm';
	global.NERP.Sales.CustomerForm = $NERP_Sales_CustomerForm;
	////////////////////////////////////////////////////////////////////////////////
	// NERP.Sales.CustomerGrid
	var $NERP_Sales_CustomerGrid = function(container) {
		ss.makeGenericType(Serenity.EntityGrid$1, [Object]).call(this, container);
	};
	$NERP_Sales_CustomerGrid.__typeName = 'NERP.Sales.CustomerGrid';
	global.NERP.Sales.CustomerGrid = $NERP_Sales_CustomerGrid;
	////////////////////////////////////////////////////////////////////////////////
	// Serenity.HtmlBasicContentEditor
	var $Serenity_HtmlBasicContentEditor = function(textArea, opt) {
		Serenity.HtmlContentEditor.call(this, textArea, opt);
	};
	$Serenity_HtmlBasicContentEditor.__typeName = 'Serenity.HtmlBasicContentEditor';
	global.Serenity.HtmlBasicContentEditor = $Serenity_HtmlBasicContentEditor;
	ss.initClass($NERP_Authorization, $asm, {});
	ss.initClass($NERP_ScriptInitialization, $asm, {});
	ss.initClass($NERP_Accounting_COADialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Accounting_COAForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_parentId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ParentId');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Accounting_COAGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Administration_LanguageDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($NERP_Administration_LanguageForm, $asm, {
		get_languageId: function() {
			return this.byId(Serenity.StringEditor).call(this, 'LanguageId');
		},
		get_languageName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'LanguageName');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Administration_LanguageGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($NERP_Administration_PermissionCheckEditor, $asm, {
		$getItemGrantRevokeClass: function(item, grant) {
			if (!item.IsGroup) {
				return ((item.GrantRevoke === grant) ? ' checked' : '');
			}
			var desc = this.$getDescendants(item, true);
			var granted = Enumerable.from(desc).where(function(x) {
				return x.GrantRevoke === grant;
			});
			if (!granted.any()) {
				return '';
			}
			else if (Enumerable.from(desc).count() === granted.count()) {
				return 'checked';
			}
			else {
				return 'checked partial';
			}
		},
		$getItemEffectiveClass: function(item) {
			if (item.IsGroup) {
				var desc = this.$getDescendants(item, true);
				var grantCount = Enumerable.from(desc).count(ss.mkdel(this, function(x) {
					return x.GrantRevoke === true || ss.isNullOrUndefined(x.GrantRevoke) && this.$rolePermissions[x.Key];
				}));
				if (grantCount === desc.length || desc.length === 0) {
					return 'allow';
				}
				else if (grantCount === 0) {
					return 'deny';
				}
				else {
					return 'partial';
				}
			}
			else {
				var granted = item.GrantRevoke === true || ss.isNullOrUndefined(item.GrantRevoke) && this.$rolePermissions[item.Key];
				return (granted ? ' allow' : ' deny');
			}
		},
		getColumns: function() {
			var $t1 = [];
			$t1.push({ name: Q.text('Site.UserPermissionDialog.Permission'), field: 'Title', format: Serenity.SlickFormatting.treeToggle(Object).call(null, ss.mkdel(this, function() {
				return this.get_view();
			}), function(x) {
				return x.Key;
			}, ss.mkdel(this, function(ctx) {
				var item = ctx.item;
				var klass = this.$getItemEffectiveClass(item);
				return "<span class='effective-permission " + klass + "'>" + Q.htmlEncode(ctx.value) + '</span>';
			})), width: 495, sortable: false });
			$t1.push({ name: Q.text('Site.UserPermissionDialog.Grant'), field: 'Grant', format: ss.mkdel(this, function(ctx1) {
				var item1 = ctx1.item;
				var klass1 = this.$getItemGrantRevokeClass(item1, true);
				return "<span class='check-box grant no-float " + klass1 + "'></span>";
			}), width: 65, sortable: false, headerCssClass: 'align-center', cssClass: 'align-center' });
			var columns = $t1;
			if (this.options.showRevoke) {
				columns.push({ name: Q.text('Site.UserPermissionDialog.Revoke'), field: 'Revoke', format: ss.mkdel(this, function(ctx2) {
					var item2 = ctx2.item;
					var klass2 = this.$getItemGrantRevokeClass(item2, false);
					return '<span class="check-box revoke no-float ' + klass2 + '"></span>';
				}), width: 65, sortable: false, headerCssClass: 'align-center', cssClass: 'align-center' });
			}
			return columns;
		},
		$setItems: function(items) {
			Serenity.SlickTreeHelper.setIndents(items, function(x) {
				return x.Key;
			}, function(x1) {
				return x1.ParentKey;
			}, false);
			this.get_view().setItems(items, true);
		},
		onViewSubmit: function() {
			return false;
		},
		onViewFilter: function(item) {
			if (!ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onViewFilter.call(this, item)) {
				return false;
			}
			if (!Serenity.SlickTreeHelper.filterById(item, this.view, function(x) {
				return x.ParentKey;
			})) {
				return false;
			}
			if (!ss.isNullOrEmptyString(this.$containsText)) {
				return this.$matchContains(item) || item.IsGroup && Enumerable.from(this.$getDescendants(item, false)).any(ss.mkdel(this, this.$matchContains));
			}
			return true;
		},
		$matchContains: function(item) {
			return Select2.util.stripDiacritics(ss.coalesce(item.Title, '')).toLowerCase().indexOf(this.$containsText) >= 0;
		},
		$getDescendants: function(item, excludeGroups) {
			var result = [];
			var stack = new Array();
			stack.push(item);
			while (stack.length > 0) {
				var i = stack.pop();
				var $t1 = this.$byParentKey.get(i.Key).getEnumerator();
				try {
					while ($t1.moveNext()) {
						var child = $t1.current();
						if (!excludeGroups || !child.IsGroup) {
							result.push(child);
						}
						stack.push(child);
					}
				}
				finally {
					$t1.dispose();
				}
			}
			return result;
		},
		onClick: function(e, row, cell) {
			ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onClick.call(this, e, row, cell);
			if (!e.isDefaultPrevented()) {
				Serenity.SlickTreeHelper.toggleClick(Object).call(null, e, row, cell, this.view, function(x) {
					return x.Key;
				});
			}
			if (e.isDefaultPrevented()) {
				return;
			}
			var target = $(e.target);
			var grant = target.hasClass('grant');
			if (ss.unbox(grant) || target.hasClass('revoke')) {
				e.preventDefault();
				var item = this.view.rows[row];
				var checkedOrPartial = target.hasClass('checked') || target.hasClass('partial');
				if (checkedOrPartial) {
					grant = null;
				}
				else {
					grant = !!(ss.unbox(grant) ^ checkedOrPartial);
				}
				this.view.beginUpdate();
				try {
					if (item.IsGroup) {
						var $t1 = this.$getDescendants(item, true);
						for (var $t2 = 0; $t2 < $t1.length; $t2++) {
							var d = $t1[$t2];
							if (!ss.referenceEquals(d.GrantRevoke, grant)) {
								d.GrantRevoke = grant;
								this.view.updateItem(d.Key, d);
							}
						}
					}
					else if (!ss.referenceEquals(item.GrantRevoke, grant)) {
						item.GrantRevoke = grant;
						this.view.updateItem(item.Key, item);
					}
				}
				finally {
					this.view.endUpdate();
				}
			}
		},
		$getParentKey: function(key) {
			if (ss.endsWithString(key, ':')) {
				key = key.substr(0, key.length - 1);
			}
			var idx = key.lastIndexOf(String.fromCharCode(58));
			if (idx >= 0) {
				return key.substr(0, idx + 1);
			}
			return null;
		},
		getButtons: function() {
			return [];
		},
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			Serenity.GridUtils.addQuickSearchInputCustom(this.toolbar.get_element(), ss.mkdel(this, function(field, text) {
				this.$containsText = Select2.util.stripDiacritics(ss.coalesce(Q.trimToNull(text), '')).toLowerCase();
				this.view.setItems(this.view.getItems(), true);
			}), null);
		},
		$getSortedGroupAndPermissionKeys: function(titleByKey) {
			var keys = Q.getRemoteData('Administration.PermissionKeys').Entities;
			titleByKey.$ = {};
			var titleWithGroup = {};
			for (var $t1 = 0; $t1 < keys.length; $t1++) {
				var k = keys[$t1];
				var s = k;
				if (ss.isNullOrEmptyString(s)) {
					continue;
				}
				if (ss.endsWithString(s, ':')) {
					s = s.substr(0, s.length - 1);
					if (s.length === 0) {
						continue;
					}
				}
				if (ss.keyExists(titleByKey.$, s)) {
					continue;
				}
				titleByKey.$[s] = ss.coalesce(Q.tryGetText('Permission.' + s), s);
				var parts = s.split(String.fromCharCode(58));
				var group = '';
				var groupTitle = '';
				for (var i = 0; i < parts.length - 1; i++) {
					group = group + parts[i] + ':';
					var $t3 = titleByKey.$;
					var $t2 = Q.tryGetText('Permission.' + group);
					if (ss.isNullOrUndefined($t2)) {
						$t2 = parts[i];
					}
					$t3[group] = $t2;
					groupTitle = groupTitle + titleByKey.$[group] + ':';
					titleWithGroup[group] = groupTitle;
				}
				titleWithGroup[s] = groupTitle + titleByKey.$[s];
			}
			keys = Enumerable.from(Object.keys(titleByKey.$)).toArray();
			keys.sort(function(x, y) {
				return Q.turkishLocaleCompare(titleWithGroup[x], titleWithGroup[y]);
			});
			return keys;
		},
		get_value: function() {
			var result = [];
			var $t1 = this.view.getItems();
			for (var $t2 = 0; $t2 < $t1.length; $t2++) {
				var item = $t1[$t2];
				if (ss.isValue(item.GrantRevoke) && !ss.endsWithString(item.Key, ':')) {
					result.push({ PermissionKey: item.Key, Grant: ss.unbox(item.GrantRevoke) });
				}
			}
			return result;
		},
		set_value: function(value) {
			var $t1 = this.view.getItems();
			for (var $t2 = 0; $t2 < $t1.length; $t2++) {
				var item = $t1[$t2];
				item.GrantRevoke = null;
			}
			if (ss.isValue(value)) {
				for (var $t3 = 0; $t3 < value.length; $t3++) {
					var row = value[$t3];
					var r = this.view.getItemById(row.PermissionKey);
					if (ss.isValue(r)) {
						r.GrantRevoke = ss.coalesce(row.Grant, true);
					}
				}
			}
			this.$setItems(this.get_items());
		},
		get_rolePermissions: function() {
			return Enumerable.from(Object.keys(this.$rolePermissions)).toArray();
		},
		set_rolePermissions: function(value) {
			ss.clearKeys(this.$rolePermissions);
			if (ss.isValue(value)) {
				for (var $t1 = 0; $t1 < value.length; $t1++) {
					var k = value[$t1];
					this.$rolePermissions[k] = true;
				}
			}
			this.$setItems(this.get_items());
		}
	}, ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Administration_PermissionModuleEditor, $asm, {}, ss.makeGenericType(Serenity.Select2Editor$2, [Object, String]), [Serenity.ISetEditValue, Serenity.IGetEditValue, Serenity.IStringValue]);
	ss.initClass($NERP_Administration_RoleCheckEditor, $asm, {
		getButtons: function() {
			return [];
		},
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			Serenity.GridUtils.addQuickSearchInputCustom(this.toolbar.get_element(), ss.mkdel(this, function(field, text) {
				this.$containsText = Q.trimToNull(text);
				this.view.setItems(this.view.getItems(), true);
			}), null);
		},
		onViewFilter: function(item) {
			if (!ss.makeGenericType(Serenity.CheckTreeEditor$2, [Object, Object]).prototype.onViewFilter.call(this, item)) {
				return false;
			}
			var contains = Select2.util.stripDiacritics(ss.coalesce(this.$containsText, '')).toUpperCase();
			if (Q.isEmptyOrNull(contains)) {
				return true;
			}
			if (Select2.util.stripDiacritics(ss.coalesce(item.text, '')).toUpperCase().indexOf(contains) !== -1) {
				return true;
			}
			return false;
		},
		getItems: function() {
			var list = [];
			var roles = Q.getLookup('Administration.Role').get_items();
			for (var $t1 = 0; $t1 < roles.length; $t1++) {
				var role = roles[$t1];
				list.push({ id: role.RoleId.toString(), text: role.RoleName });
			}
			return list;
		}
	}, ss.makeGenericType(Serenity.CheckTreeEditor$1, [Object]), [Serenity.IDataGrid, Serenity.IGetEditValue, Serenity.ISetEditValue]);
	ss.initClass($NERP_Administration_RoleDialog, $asm, {
		getToolbarButtons: function() {
			var buttons = ss.makeGenericType(Serenity.EntityDialog$2, [Object, Object]).prototype.getToolbarButtons.call(this);
			buttons.push({ title: Q.text('Site.RolePermissionDialog.EditButton'), cssClass: 'lock-button', onClick: ss.mkdel(this, function() {
				(new $NERP_Administration_RolePermissionDialog({ roleID: ss.unbox(this.get_entity().RoleId), title: this.get_entity().RoleName })).dialogOpen();
			}) });
			return buttons;
		},
		updateInterface: function() {
			ss.makeGenericType(Serenity.EntityDialog$2, [Object, Object]).prototype.updateInterface.call(this);
			this.toolbar.findButton('lock-button').toggleClass('disabled', this.get_isNewOrDeleted());
		}
	}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($NERP_Administration_RoleForm, $asm, {
		get_roleName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'RoleName');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Administration_RoleGrid, $asm, {
		getDefaultSortBy: function() {
			var $t1 = [];
			$t1.push('RoleName');
			return $t1;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($NERP_Administration_RolePermissionDialog, $asm, {
		getDialogOptions: function() {
			var opt = ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).prototype.getDialogOptions.call(this);
			var $t1 = [];
			$t1.push({ text: Q.text('Dialogs.OkButton'), click: ss.mkdel(this, function() {
				Q.serviceRequest('Administration/RolePermission/Update', { RoleID: this.options.roleID, Permissions: Enumerable.from(this.$permissions.get_value()).select(function(x) {
					return x.PermissionKey;
				}).toArray(), Module: null, Submodule: null }, ss.mkdel(this, function(response) {
					this.dialogClose();
					window.setTimeout(function() {
						Q.notifySuccess(Q.text('Site.RolePermissionDialog.SaveSuccess'));
					}, 0);
				}), null);
			}) });
			$t1.push({ text: Q.text('Dialogs.CancelButton'), click: ss.mkdel(this, this.dialogClose) });
			opt.buttons = $t1;
			opt.title = ss.formatString(Q.text('Site.RolePermissionDialog.DialogTitle'), this.options.title);
			return opt;
		},
		getTemplate: function() {
			return "<div id='~_Permissions'></div>";
		}
	}, ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]), [Serenity.IDialog]);
	ss.initClass($NERP_Administration_TranslationGrid, $asm, {
		onClick: function(e, row, cell) {
			ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onClick.call(this, e, row, cell);
			if (e.isDefaultPrevented()) {
				return;
			}
			if ($(e.target).hasClass('source-text')) {
				e.preventDefault();
				var item = this.view.rows[row];
				var done = ss.mkdel(this, function() {
					item.CustomText = item.SourceText;
					this.view.updateItem(item.Key, item);
					this.$hasChanges = true;
				});
				if (Q.isTrimmedEmpty(item.CustomText) || ss.referenceEquals(Q.trimToEmpty(item.CustomText), Q.trimToEmpty(item.SourceText))) {
					done();
					return;
				}
				Q.confirm(Q.text('Db.Administration.Translation.OverrideConfirmation'), done);
			}
			if ($(e.target).hasClass('target-text')) {
				e.preventDefault();
				var item1 = this.view.rows[row];
				var done1 = ss.mkdel(this, function() {
					item1.CustomText = item1.TargetText;
					this.view.updateItem(item1.Key, item1);
					this.$hasChanges = true;
				});
				if (Q.isTrimmedEmpty(item1.CustomText) || ss.referenceEquals(Q.trimToEmpty(item1.CustomText), Q.trimToEmpty(item1.TargetText))) {
					done1();
					return;
				}
				Q.confirm(Q.text('Db.Administration.Translation.OverrideConfirmation'), done1);
			}
		},
		getColumnsAsync: function() {
			var columns = [];
			columns.push({ field: 'Key', width: 300, sortable: false });
			columns.push({
				field: 'SourceText',
				width: 300,
				sortable: false,
				format: function(ctx) {
					return Q.outerHtml($('<a/>').addClass('source-text').text(ss.coalesce(ss.cast(ctx.value, String), '')));
				}
			});
			columns.push({
				field: 'CustomText',
				width: 300,
				sortable: false,
				format: function(ctx1) {
					return Q.outerHtml($('<input/>').addClass('custom-text').attr('value', ss.cast(ctx1.value, String)).attr('type', 'text').attr('data-key', ss.cast(ctx1.item.Key, String)));
				}
			});
			columns.push({
				field: 'TargetText',
				width: 300,
				sortable: false,
				format: function(ctx2) {
					return Q.outerHtml($('<a/>').addClass('target-text').text(ss.coalesce(ss.cast(ctx2.value, String), '')));
				}
			});
			return RSVP.resolve(columns);
		},
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			var $t2 = ss.mkdel(this, function(e) {
				e.appendTo(this.toolbar.get_element()).attr('placeholder', '--- ' + Q.text('Db.Administration.Translation.SourceLanguage') + ' ---');
			});
			var $t1 = Serenity.LookupEditorOptions.$ctor();
			$t1.lookupKey = 'Administration.Language';
			this.$sourceLanguage = Serenity.Widget.create(Serenity.LookupEditor).call(null, $t2, $t1, null);
			Serenity.WX.changeSelect2(this.$sourceLanguage, ss.mkdel(this, function(e1) {
				if (this.$hasChanges) {
					this.saveChanges(this.$targetLanguageKey).then(ss.mkdel(this, this.refresh), null);
				}
				else {
					this.refresh();
				}
			}));
			var $t4 = ss.mkdel(this, function(e2) {
				e2.appendTo(this.toolbar.get_element()).attr('placeholder', '--- ' + Q.text('Db.Administration.Translation.TargetLanguage') + ' ---');
			});
			var $t3 = Serenity.LookupEditorOptions.$ctor();
			$t3.lookupKey = 'Administration.Language';
			this.$targetLanguage = Serenity.Widget.create(Serenity.LookupEditor).call(null, $t4, $t3, null);
			Serenity.WX.changeSelect2(this.$targetLanguage, ss.mkdel(this, function(e3) {
				if (this.$hasChanges) {
					this.saveChanges(this.$targetLanguageKey).then(ss.mkdel(this, this.refresh), null);
				}
				else {
					this.refresh();
				}
			}));
		},
		saveChanges: function(language) {
			var translations = {};
			var $t1 = this.view.getItems();
			for (var $t2 = 0; $t2 < $t1.length; $t2++) {
				var item = $t1[$t2];
				translations[item.Key] = item.CustomText;
			}
			return RSVP.resolve(Q.serviceRequest('Administration/Translation/Update', { TargetLanguageID: language, Translations: translations }, null, null)).then(ss.mkdel(this, function() {
				this.$hasChanges = false;
				language = ss.coalesce(Q.trimToNull(language), 'invariant');
				Q.notifySuccess('User translations in "' + language + '" language are saved to "user.texts.' + language + '.json" ' + 'file under "~/App_Data/texts/"');
			}), null);
		},
		onViewSubmit: function() {
			var request = this.view.params;
			request.SourceLanguageID = this.$sourceLanguage.get_value();
			this.$targetLanguageKey = ss.coalesce(this.$targetLanguage.get_value(), '');
			request.TargetLanguageID = this.$targetLanguageKey;
			this.$hasChanges = false;
			return ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onViewSubmit.call(this);
		},
		getButtons: function() {
			var $t1 = [];
			$t1.push({ title: Q.text('Db.Administration.Translation.SaveChangesButton'), onClick: ss.mkdel(this, function(e) {
				this.saveChanges(this.$targetLanguageKey).then(ss.mkdel(this, this.refresh), null);
			}), cssClass: 'apply-changes-button' });
			return $t1;
		},
		createQuickSearchInput: function() {
			Serenity.GridUtils.addQuickSearchInputCustom(this.toolbar.get_element(), ss.mkdel(this, function(field, searchText) {
				this.$searchText = searchText;
				this.view.setItems(this.view.getItems(), true);
			}), null);
		},
		onViewFilter: function(item) {
			if (!ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onViewFilter.call(this, item)) {
				return false;
			}
			if (Q.isEmptyOrNull(this.$searchText)) {
				return true;
			}
			var searching = Select2.util.stripDiacritics(this.$searchText).toLowerCase();
			if (Q.isEmptyOrNull(searching)) {
				return true;
			}
			if (Select2.util.stripDiacritics(ss.coalesce(item.Key, '')).toLowerCase().indexOf(searching) >= 0) {
				return true;
			}
			if (Select2.util.stripDiacritics(ss.coalesce(item.SourceText, '')).toLowerCase().indexOf(searching) >= 0) {
				return true;
			}
			if (Select2.util.stripDiacritics(ss.coalesce(item.TargetText, '')).toLowerCase().indexOf(searching) >= 0) {
				return true;
			}
			if (Select2.util.stripDiacritics(ss.coalesce(item.CustomText, '')).toLowerCase().indexOf(searching) >= 0) {
				return true;
			}
			return false;
		},
		usePager: function() {
			return false;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($NERP_Administration_UserDialog, $asm, {
		getToolbarButtons: function() {
			var buttons = ss.makeGenericType(Serenity.EntityDialog$2, [Object, Object]).prototype.getToolbarButtons.call(this);
			buttons.push({ title: Q.text('Site.UserDialog.EditRolesButton'), cssClass: 'users-button', onClick: ss.mkdel(this, function() {
				(new $NERP_Administration_UserRoleDialog({ userID: ss.unbox(this.get_entity().UserId), username: this.get_entity().Username })).dialogOpen();
			}) });
			buttons.push({ title: Q.text('Site.UserDialog.EditPermissionsButton'), cssClass: 'lock-button', onClick: ss.mkdel(this, function() {
				(new $NERP_Administration_UserPermissionDialog({ userID: ss.unbox(this.get_entity().UserId), username: this.get_entity().Username })).dialogOpen();
			}) });
			return buttons;
		},
		updateInterface: function() {
			ss.makeGenericType(Serenity.EntityDialog$2, [Object, Object]).prototype.updateInterface.call(this);
			this.toolbar.findButton('users-button').toggleClass('disabled', this.get_isNewOrDeleted());
			this.toolbar.findButton('lock-button').toggleClass('disabled', this.get_isNewOrDeleted());
		}
	}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Administration_UserForm, $asm, {
		get_username: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Username');
		},
		get_displayName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'DisplayName');
		},
		get_email: function() {
			return this.byId(Serenity.EmailEditor).call(this, 'Email');
		},
		get_password: function() {
			return this.byId(Serenity.PasswordEditor).call(this, 'Password');
		},
		get_passwordConfirm: function() {
			return this.byId(Serenity.PasswordEditor).call(this, 'PasswordConfirm');
		},
		get_source: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Source');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Administration_UserGrid, $asm, {
		getColumns: function() {
			var columns = ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this);
			columns.push({ field: 'UserId', width: 55, cssClass: 'align-right', name: Q.text('Db.Shared.RecordId') });
			columns.push({ field: 'Username', width: 150, format: this.itemLink(null, null, null, null, true) });
			columns.push({ field: 'DisplayName', width: 150 });
			columns.push({ field: 'Email', width: 250 });
			columns.push({ field: 'Source', width: 100 });
			return columns;
		},
		getDefaultSortBy: function() {
			var $t1 = [];
			$t1.push('Username');
			return $t1;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Administration_UserPermissionDialog, $asm, {
		getDialogOptions: function() {
			var opt = ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).prototype.getDialogOptions.call(this);
			var $t1 = [];
			$t1.push({ text: Q.text('Dialogs.OkButton'), click: ss.mkdel(this, function() {
				Q.serviceRequest('Administration/UserPermission/Update', { UserID: this.options.userID, Permissions: this.$permissions.get_value(), Module: null, Submodule: null }, ss.mkdel(this, function(response) {
					this.dialogClose();
					window.setTimeout(function() {
						Q.notifySuccess(Q.text('Site.UserPermissionDialog.SaveSuccess'));
					}, 0);
				}), null);
			}) });
			$t1.push({ text: Q.text('Dialogs.CancelButton'), click: ss.mkdel(this, this.dialogClose) });
			opt.buttons = $t1;
			opt.title = ss.formatString(Q.text('Site.UserPermissionDialog.DialogTitle'), this.options.username);
			return opt;
		},
		getTemplate: function() {
			return "<div id='~_Permissions'></div>";
		}
	}, ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]), [Serenity.IDialog]);
	ss.initClass($NERP_Administration_UserRoleDialog, $asm, {
		getDialogOptions: function() {
			var opt = ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).prototype.getDialogOptions.call(this);
			var $t1 = [];
			$t1.push({ text: Q.text('Dialogs.OkButton'), click: ss.mkdel(this, function() {
				Q.serviceRequest('Administration/UserRole/Update', { UserID: this.options.userID, Roles: Enumerable.from(this.$permissions.get_value()).select(function(x) {
					return parseInt(x, 10);
				}).toArray() }, ss.mkdel(this, function(response) {
					this.dialogClose();
					window.setTimeout(function() {
						Q.notifySuccess(Q.text('Site.UserRoleDialog.SaveSuccess'));
					}, 0);
				}), null);
			}) });
			$t1.push({ text: Q.text('Dialogs.CancelButton'), click: ss.mkdel(this, this.dialogClose) });
			opt.buttons = $t1;
			opt.title = ss.formatString(Q.text('Site.UserRoleDialog.DialogTitle'), this.options.username);
			return opt;
		},
		getTemplate: function() {
			return "<div id='~_Roles'></div>";
		}
	}, ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]), [Serenity.IDialog]);
	ss.initClass($NERP_Common_ExcelExportHelper, $asm, {});
	ss.initClass($NERP_Common_LanguageSelection, $asm, {}, Serenity.Widget);
	ss.initClass($NERP_Common_SidebarSearch, $asm, {
		$updateMatchFlags: function(text) {
			var liList = this.$menuUL.find('li').removeClass('non-match');
			text = Q.trimToNull(text);
			if (ss.isNullOrUndefined(text)) {
				liList.show();
				liList.removeClass('expanded');
				return;
			}
			var parts = ss.netSplit(text, [44, 32].map(function(i) {
				return String.fromCharCode(i);
			}), null, 1);
			for (var i = 0; i < parts.length; i++) {
				parts[i] = Q.trimToNull(Select2.util.stripDiacritics(parts[i]).toUpperCase());
			}
			var items = liList;
			items.each(function(i1, e) {
				var x = $(e);
				var title = Select2.util.stripDiacritics(ss.coalesce(x.text(), '').toUpperCase());
				for (var $t1 = 0; $t1 < parts.length; $t1++) {
					var p = parts[$t1];
					if (ss.isValue(p) && !(title.indexOf(p) !== -1)) {
						x.addClass('non-match');
						break;
					}
				}
			});
			var matchingItems = items.not('.non-match');
			var visibles = matchingItems.parents('li').add(matchingItems);
			var nonVisibles = liList.not(visibles);
			nonVisibles.hide().addClass('non-match');
			visibles.show();
			liList.addClass('expanded');
		}
	}, Serenity.Widget);
	ss.initClass($NERP_Common_ThemeSelection, $asm, {
		$getCurrentTheme: function() {
			var skinClass = Enumerable.from(ss.coalesce($('body').attr('class'), '').split(String.fromCharCode(32))).firstOrDefault(function(x) {
				return ss.startsWithString(x, 'skin-');
			}, ss.getDefaultValue(String));
			if (ss.isValue(skinClass)) {
				return skinClass.substr(5);
			}
			return 'blue';
		}
	}, Serenity.Widget);
	ss.initClass($NERP_Configuration_BrandDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_BrandForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_BrandGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_ColorDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_ColorForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_hexValue: function() {
			return this.byId(Serenity.StringEditor).call(this, 'HexValue');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_ColorGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_CurrencyDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_CurrencyForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_symbol: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Symbol');
		},
		get_decimalPlaces: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'DecimalPlaces');
		},
		get_decimalSeparator: function() {
			return this.byId(Serenity.StringEditor).call(this, 'DecimalSeparator');
		},
		get_isThousandBase: function() {
			return this.byId(Serenity.BooleanEditor).call(this, 'IsThousandBase');
		},
		get_thousandSeparator: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ThousandSeparator');
		},
		get_rateToDollar: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'RateToDollar');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_CurrencyGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_GenericItemDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_GenericItemForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_itemCategoryId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'ItemCategoryId');
		},
		get_itemTypeId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ItemTypeId');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_GenericItemGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_ItemCategoryDialog, $asm, {
		onDialogOpen: function() {
			ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).prototype.onDialogOpen.call(this);
			var prior = $('.ui-dialog').eq(-2);
			if (prior.length > 0) {
				if (prior.hasClass(this.getCssClass())) {
					Serenity.SubDialogHelper.cascade(this, prior);
				}
			}
		}
	}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_ItemCategoryForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_parentId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'ParentId');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_ItemCategoryGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_ItemDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_ItemForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_itemGroupId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ItemGroupId');
		},
		get_uomId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'UomId');
		},
		get_specificationId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'SpecificationId');
		},
		get_colorId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'ColorId');
		},
		get_sizeId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'SizeId');
		},
		get_modelId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'ModelId');
		},
		get_styleId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'StyleId');
		},
		get_brandId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'BrandId');
		},
		get_countryId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'CountryId');
		},
		get_seasonId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'SeasonId');
		},
		get_purposeId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'PurposeId');
		},
		get_supplierId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'SupplierId');
		},
		get_conditionId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ConditionId');
		},
		get_qualityId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'QualityId');
		},
		get_year: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'Year');
		},
		get_expireDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'ExpireDate');
		},
		get_lifeTime: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'LifeTime');
		},
		get_barcode: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Barcode');
		},
		get_unitWeight: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'UnitWeight');
		},
		get_weightUomId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'WeightUomId');
		},
		get_reorderLevel: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'ReorderLevel');
		},
		get_costPrice: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'CostPrice');
		},
		get_sellingPrice: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'SellingPrice');
		},
		get_promoPrice: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'PromoPrice');
		},
		get_promoStartDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'PromoStartDate');
		},
		get_promoEndDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'PromoEndDate');
		},
		get_commissionAmt: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'CommissionAmt');
		},
		get_isCommissionPercent: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'IsCommissionPercent');
		},
		get_isTaxInclude: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'IsTaxInclude');
		},
		get_isOverrideTax: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'IsOverrideTax');
		},
		get_tax1: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Tax1');
		},
		get_tax2: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Tax2');
		},
		get_tax3: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Tax3');
		},
		get_tax4: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Tax4');
		},
		get_tax5: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Tax5');
		},
		get_tax1Rate: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'Tax1Rate');
		},
		get_tax2Rate: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'Tax2Rate');
		},
		get_tax3Rate: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'Tax3Rate');
		},
		get_tax4Rate: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'Tax4Rate');
		},
		get_tax5Rate: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'Tax5Rate');
		},
		get_defaultQty: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'DefaultQty');
		},
		get_defaultLocationAtStore: function() {
			return this.byId(Serenity.StringEditor).call(this, 'DefaultLocationAtStore');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_ItemGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_ItemTaxDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_ItemTaxForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_itemId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ItemId');
		},
		get_taxId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'TaxId');
		},
		get_rate: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'Rate');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_ItemTaxGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_ModelDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_ModelForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_ModelGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_OrganogramDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_OrganogramForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_parentId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'ParentId');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_OrganogramGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_PaymentMethodDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_PaymentMethodForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_isPaymentDetailReq: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'IsPaymentDetailReq');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_PaymentMethodGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_ProjectDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_ProjectForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_ProjectGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_SizeDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_SizeForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_SizeGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_SpecificationDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_SpecificationForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_SpecificationGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_StyleDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_StyleForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_StyleGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_TaxDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_TaxForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_rate: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'Rate');
		},
		get_isDefault: function() {
			return this.byId(Serenity.BooleanEditor).call(this, 'IsDefault');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_TaxGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Configuration_UomDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Configuration_UomForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_uomTyepId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'UomTyepId');
		},
		get_rateToStandard: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'RateToStandard');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Configuration_UomGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_HR_EmployeeDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_HR_EmployeeForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_userTypeId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'UserTypeId');
		},
		get_userGroupId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'UserGroupId');
		},
		get_firstName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'FirstName');
		},
		get_middleName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'MiddleName');
		},
		get_lastName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'LastName');
		},
		get_fullName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'FullName');
		},
		get_imageId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ImageId');
		},
		get_address1: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Address1');
		},
		get_address2: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Address2');
		},
		get_mobile: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Mobile');
		},
		get_email: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Email');
		},
		get_dateOfBirth: function() {
			return this.byId(Serenity.DateEditor).call(this, 'DateOfBirth');
		},
		get_loginName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'LoginName');
		},
		get_password: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Password');
		},
		get_isTaxable: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'IsTaxable');
		},
		get_commissionRate: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'CommissionRate');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_HR_EmployeeGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Inventory_StockDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Inventory_StockForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_itemId: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ItemId');
		},
		get_itemDetailId: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ItemDetailId');
		},
		get_uomId: function() {
			return this.byId(Serenity.StringEditor).call(this, 'UomId');
		},
		get_openingStock: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'OpeningStock');
		},
		get_openingStockVal: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'OpeningStockVal');
		},
		get_receivedQty: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'ReceivedQty');
		},
		get_receivedVal: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'ReceivedVal');
		},
		get_deliveredQty: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'DeliveredQty');
		},
		get_deliveredVal: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'DeliveredVal');
		},
		get_currentStock: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'CurrentStock');
		},
		get_currentStockVal: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'CurrentStockVal');
		},
		get_openingStockDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'OpeningStockDate');
		},
		get_lastReceivedDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'LastReceivedDate');
		},
		get_lastDeliveredDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'LastDeliveredDate');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Inventory_StockGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_ItemTransaction_TransDetailDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_ItemTransaction_TransDetailEditDialog, $asm, {}, ss.makeGenericType($NERP_Common_GridEditorDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_ItemTransaction_TransDetailEditor, $asm, {
		createToolbarExtensions: function() {
			var input = $('<input type="text" id="txtBarcode"/>');
			this.toolbar.get_element().append(input);
			input.click(ss.mkdel(this, function(e) {
				this.addEntity({ ItemId: 3, Name: 'dfsa' });
			}));
			ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
		},
		validateEntity: function(row, id) {
			if (!ss.makeGenericType($NERP_Common_GridEditorBase$1, [Object]).prototype.validateEntity.call(this, row, id)) {
				return false;
			}
			row.ItemName = Q.getLookup('Configuration.Item').get_itemById()[ss.unbox(row.ItemId)].Name;
			row.UomName = Q.getLookup('Configuration.Uom').get_itemById()[ss.unbox(row.UomId)].Name;
			return true;
		}
	}, ss.makeGenericType($NERP_Common_GridEditorBase$1, [Object]), [Serenity.IDataGrid, Serenity.ISetEditValue, Serenity.IGetEditValue]);
	ss.initClass($NERP_ItemTransaction_TransDetailForm, $asm, {
		get_itemId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'ItemId');
		},
		get_itemName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ItemName');
		},
		get_uomId: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'UomId');
		},
		get_quantity: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'Quantity');
		},
		get_unitPrice: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'UnitPrice');
		},
		get_amount: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'Amount');
		},
		get_taxAmt: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'TaxAmt');
		},
		get_discountAmt: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'DiscountAmt');
		},
		get_lineTotalAmt: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'LineTotalAmt');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_ItemTransaction_TransDetailGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_ItemTransaction_TransDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_ItemTransaction_TransForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_dateTime: function() {
			return this.byId(Serenity.DateEditor).call(this, 'DateTime');
		},
		get_transTypeId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'TransTypeId');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		},
		get_transDetailRows: function() {
			return this.byId($NERP_ItemTransaction_TransDetailEditor).call(this, 'TransDetailRows');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_ItemTransaction_TransGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_ItemTransaction_TransPaymentDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_ItemTransaction_TransPaymentForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_transId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'TransId');
		},
		get_paymentMethodId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'PaymentMethodId');
		},
		get_paymentAmt: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'PaymentAmt');
		},
		get_paymentMeansNo: function() {
			return this.byId(Serenity.StringEditor).call(this, 'PaymentMeansNo');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_ItemTransaction_TransPaymentGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_ItemTransaction_TransTaxDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_ItemTransaction_TransTaxForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_transId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'TransId');
		},
		get_transDetailId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'TransDetailId');
		},
		get_taxId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'TaxId');
		},
		get_rate: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'Rate');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_ItemTransaction_TransTaxGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Membership_ChangePasswordForm, $asm, {
		get_oldPassword: function() {
			return this.byId(Serenity.PasswordEditor).call(this, 'OldPassword');
		},
		get_newPassword: function() {
			return this.byId(Serenity.PasswordEditor).call(this, 'NewPassword');
		},
		get_confirmPassword: function() {
			return this.byId(Serenity.PasswordEditor).call(this, 'ConfirmPassword');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Membership_ChangePasswordPanel, $asm, {}, ss.makeGenericType(Serenity.PropertyPanel$1, [Object]));
	ss.initClass($NERP_Membership_ForgotPasswordForm, $asm, {
		get_email: function() {
			return this.byId(Serenity.EmailEditor).call(this, 'Email');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Membership_ForgotPasswordPanel, $asm, {}, ss.makeGenericType(Serenity.PropertyPanel$1, [Object]));
	ss.initClass($NERP_Membership_LoginForm, $asm, {
		get_username: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Username');
		},
		get_password: function() {
			return this.byId(Serenity.PasswordEditor).call(this, 'Password');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Membership_LoginPanel, $asm, {}, ss.makeGenericType(Serenity.PropertyPanel$1, [Object]));
	ss.initClass($NERP_Membership_ResetPasswordForm, $asm, {
		get_newPassword: function() {
			return this.byId(Serenity.PasswordEditor).call(this, 'NewPassword');
		},
		get_confirmPassword: function() {
			return this.byId(Serenity.PasswordEditor).call(this, 'ConfirmPassword');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Membership_ResetPasswordPanel, $asm, {}, ss.makeGenericType(Serenity.PropertyPanel$1, [Object]));
	ss.initClass($NERP_Membership_SignUpForm, $asm, {
		get_displayName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'DisplayName');
		},
		get_email: function() {
			return this.byId(Serenity.EmailEditor).call(this, 'Email');
		},
		get_confirmEmail: function() {
			return this.byId(Serenity.EmailEditor).call(this, 'ConfirmEmail');
		},
		get_password: function() {
			return this.byId(Serenity.PasswordEditor).call(this, 'Password');
		},
		get_confirmPassword: function() {
			return this.byId(Serenity.PasswordEditor).call(this, 'ConfirmPassword');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Membership_SignUpPanel, $asm, {}, ss.makeGenericType(Serenity.PropertyPanel$1, [Object]));
	ss.initClass($NERP_Northwind_CategoryDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_CategoryForm, $asm, {
		get_categoryName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CategoryName');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Northwind_CategoryGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_CustomerCustomerDemoDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_CustomerCustomerDemoForm, $asm, {
		get_customerID: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CustomerID');
		},
		get_customerTypeID: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CustomerTypeID');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Northwind_CustomerCustomerDemoGrid, $asm, {
		getColumns: function() {
			var columns = ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this);
			columns.push({ field: 'ID', width: 55, cssClass: 'align-right', name: Q.text('Db.Shared.RecordId') });
			columns.push({ field: 'CustomerID', width: 200, format: this.itemLink(null, null, null, null, true) });
			columns.push({ field: 'CustomerTypeID', width: 80 });
			return columns;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Northwind_CustomerDemographicDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_CustomerDemographicForm, $asm, {
		get_customerTypeID: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CustomerTypeID');
		},
		get_customerDesc: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CustomerDesc');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Northwind_CustomerDemographicGrid, $asm, {
		getColumns: function() {
			var columns = ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this);
			columns.push({ field: 'ID', width: 55, cssClass: 'align-right', name: Q.text('Db.Shared.RecordId') });
			columns.push({ field: 'CustomerTypeID', width: 200, format: this.itemLink(null, null, null, null, true) });
			columns.push({ field: 'CustomerDesc', width: 80 });
			return columns;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Northwind_CustomerDialog, $asm, {
		loadEntity: function(entity) {
			ss.makeGenericType(Serenity.EntityDialog$2, [Object, Object]).prototype.loadEntity.call(this, entity);
			Serenity.TabsExtensions.setDisabled(this.tabs, 'Orders', this.get_isNewOrDeleted());
			this.$ordersGrid.set_customerID(entity.CustomerID);
		},
		onSaveSuccess: function(response) {
			ss.makeGenericType(Serenity.EntityDialog$2, [Object, Object]).prototype.onSaveSuccess.call(this, response);
			Q.reloadLookup('Northwind.Customer');
		}
	}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Northwind_CustomerEditor, $asm, {
		getLookupKey: function() {
			return 'Northwind.Customer';
		},
		getItemText: function(item, lookup) {
			return ss.makeGenericType(Serenity.LookupEditorBase$2, [Serenity.LookupEditorOptions, Object]).prototype.getItemText.call(this, item, lookup) + ' [' + item.CustomerID + ']';
		}
	}, ss.makeGenericType(Serenity.LookupEditorBase$1, [Object]), [Serenity.ISetEditValue, Serenity.IGetEditValue, Serenity.IStringValue]);
	ss.initClass($NERP_Northwind_CustomerForm, $asm, {
		get_customerID: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CustomerID');
		},
		get_companyName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CompanyName');
		},
		get_contactName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ContactName');
		},
		get_contactTitle: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ContactTitle');
		},
		get_representatives: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'Representatives');
		},
		get_address: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Address');
		},
		get_city: function() {
			return this.byId(Serenity.StringEditor).call(this, 'City');
		},
		get_region: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Region');
		},
		get_postalCode: function() {
			return this.byId(Serenity.StringEditor).call(this, 'PostalCode');
		},
		get_country: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Country');
		},
		get_phone: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Phone');
		},
		get_fax: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Fax');
		},
		get_noteList: function() {
			return this.byId($NERP_Northwind_NotesEditor).call(this, 'NoteList');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Northwind_CustomerGrid, $asm, {
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			var $t1 = Serenity.LookupEditorOptions.$ctor();
			$t1.lookupKey = 'Northwind.CustomerCountry';
			this.addEqualityFilter(Serenity.LookupEditor).call(this, 'Country', null, $t1, null, null, null);
			var $t2 = Serenity.LookupEditorOptions.$ctor();
			$t2.lookupKey = 'Northwind.CustomerCity';
			$t2.cascadeFrom = 'Country';
			this.addEqualityFilter(Serenity.LookupEditor).call(this, 'City', null, $t2, null, null, null);
		},
		getButtons: function() {
			var buttons = ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.getButtons.call(this);
			buttons.push($NERP_Common_ExcelExportHelper.createToolButton(this, 'Northwind/Customer/ListExcel', ss.mkdel(this, this.onViewSubmit), 'Excel'));
			return buttons;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_OrderDialog, $asm, {
		loadEntity: function(entity) {
			ss.makeGenericType(Serenity.EntityDialog$2, [Object, Object]).prototype.loadEntity.call(this, entity);
		}
	}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Northwind_CustomerOrderDialog, $asm, {
		updateInterface: function() {
			ss.makeGenericType(Serenity.EntityDialog$2, [Object, Object]).prototype.updateInterface.call(this);
			Serenity.EditorUtils.setReadOnly(this.form.get_customerID(), true);
		}
	}, $NERP_Northwind_OrderDialog, [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Northwind_OrderGrid, $asm, {
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			this.set_customerFilter(this.addEqualityFilter($NERP_Northwind_CustomerEditor).call(this, 'CustomerID', null, null, null, null, null));
			this.addDateRangeFilter('OrderDate', null);
			var $t1 = Serenity.EnumEditorOptions.$ctor();
			$t1.enumKey = 'Northwind.OrderShippingState';
			this.$shippingState = this.addEqualityFilter(Serenity.EnumEditor).call(this, 'ShippingState', null, $t1, null, null, null);
			var $t2 = Serenity.LookupEditorOptions.$ctor();
			$t2.lookupKey = 'Northwind.Shipper';
			this.addEqualityFilter(Serenity.LookupEditor).call(this, 'ShipVia', null, $t2, null, null, null);
			var $t3 = Serenity.LookupEditorOptions.$ctor();
			$t3.lookupKey = 'Northwind.OrderShipCountry';
			this.addEqualityFilter(Serenity.LookupEditor).call(this, 'ShipCountry', null, $t3, null, null, null);
			var $t4 = Serenity.LookupEditorOptions.$ctor();
			$t4.lookupKey = 'Northwind.OrderShipCity';
			$t4.cascadeFrom = 'ShipCountry';
			this.addEqualityFilter(Serenity.LookupEditor).call(this, 'ShipCity', null, $t4, null, null, null);
			var $t5 = Serenity.LookupEditorOptions.$ctor();
			$t5.lookupKey = 'Northwind.Employee';
			this.addEqualityFilter(Serenity.LookupEditor).call(this, 'EmployeeID', null, $t5, null, null, null);
		},
		get_shippingState: function() {
			return Serenity.IdExtensions.toInt32(this.$shippingState.get_value());
		},
		set_shippingState: function(value) {
			this.$shippingState.set_value((ss.isNullOrUndefined(value) ? '' : ss.unbox(value).toString()));
		},
		getButtons: function() {
			var buttons = ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.getButtons.call(this);
			buttons.push($NERP_Common_ExcelExportHelper.createToolButton(this, 'Northwind/Order/ListExcel', ss.mkdel(this, this.onViewSubmit), 'Excel'));
			return buttons;
		},
		get_customerFilter: function() {
			return this.$7$CustomerFilterField;
		},
		set_customerFilter: function(value) {
			this.$7$CustomerFilterField = value;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Northwind_CustomerOrdersGrid, $asm, {
		getColumns: function() {
			return Enumerable.from(ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this)).where(function(x) {
				return x.field !== 'CustomerCompanyName';
			}).toArray();
		},
		initEntityDialog$1: function(itemType, dialog) {
			ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.initEntityDialog$1.call(this, itemType, dialog);
			Serenity.SubDialogHelper.cascade(ss.cast(dialog, $NERP_Northwind_OrderDialog), this.get_element().closest('.ui-dialog'));
		},
		addButtonClick: function() {
			this.editItem({ CustomerID: this.get_customerID() });
		},
		getInitialTitle: function() {
			return null;
		},
		createToolbarExtensions: function() {
			$NERP_Northwind_OrderGrid.prototype.createToolbarExtensions.call(this);
			this.get_customerFilter().get_element().closest('.quick-filter-item').remove();
		},
		getGridCanLoad: function() {
			return ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getGridCanLoad.call(this) && !ss.isNullOrEmptyString(this.$customerID);
		},
		get_customerID: function() {
			return this.$customerID;
		},
		set_customerID: function(value) {
			if (!ss.referenceEquals(this.$customerID, value)) {
				this.$customerID = value;
				this.setEquality('CustomerID', this.get_customerID());
				this.refresh();
			}
		}
	}, $NERP_Northwind_OrderGrid, [Serenity.IDataGrid]);
	ss.initClass($NERP_Northwind_EmployeeDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_EmployeeForm, $asm, {
		get_lastName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'LastName');
		},
		get_firstName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'FirstName');
		},
		get_title: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Title');
		},
		get_titleOfCourtesy: function() {
			return this.byId(Serenity.StringEditor).call(this, 'TitleOfCourtesy');
		},
		get_birthDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'BirthDate');
		},
		get_hireDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'HireDate');
		},
		get_address: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Address');
		},
		get_city: function() {
			return this.byId(Serenity.StringEditor).call(this, 'City');
		},
		get_region: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Region');
		},
		get_postalCode: function() {
			return this.byId(Serenity.StringEditor).call(this, 'PostalCode');
		},
		get_country: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Country');
		},
		get_homePhone: function() {
			return this.byId(Serenity.StringEditor).call(this, 'HomePhone');
		},
		get_extension: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Extension');
		},
		get_photo: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Photo');
		},
		get_notes: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Notes');
		},
		get_reportsTo: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ReportsTo');
		},
		get_photoPath: function() {
			return this.byId(Serenity.StringEditor).call(this, 'PhotoPath');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Northwind_EmployeeFormatter, $asm, {
		format: function(ctx) {
			var text = Q.htmlEncode(ctx.value);
			if (ss.isNullOrEmptyString(this.get_genderProperty())) {
				return text;
			}
			var gender = ss.safeCast(ctx.item[this.get_genderProperty()], ss.Int32);
			return "<span class='" + ((gender === 2) ? 'employee-symbol female' : 'employee-symbol male') + "'>" + text + '</span>';
		},
		get_genderProperty: function() {
			return this.$1$GenderPropertyField;
		},
		set_genderProperty: function(value) {
			this.$1$GenderPropertyField = value;
		},
		initializeColumn: function(column) {
			column.referencedFields = column.referencedFields || [];
			if (!ss.isNullOrEmptyString(this.get_genderProperty())) {
				column.referencedFields.push(this.get_genderProperty());
				return;
			}
		}
	}, null, [Serenity.ISlickFormatter, Serenity.IInitializeColumn]);
	ss.initClass($NERP_Northwind_EmployeeGrid, $asm, {
		getColumns: function() {
			var columns = ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this);
			columns.push({ field: 'EmployeeID', width: 55, cssClass: 'align-right', name: Q.text('Db.Shared.RecordId') });
			columns.push({ field: 'LastName', width: 200, format: this.itemLink(null, null, null, null, true) });
			columns.push({ field: 'FirstName', width: 80 });
			columns.push({ field: 'Title', width: 80 });
			columns.push({ field: 'TitleOfCourtesy', width: 80 });
			columns.push({ field: 'BirthDate', width: 80 });
			columns.push({ field: 'HireDate', width: 80 });
			columns.push({ field: 'Address', width: 80 });
			columns.push({ field: 'City', width: 80 });
			columns.push({ field: 'Region', width: 80 });
			columns.push({ field: 'PostalCode', width: 80 });
			columns.push({ field: 'Country', width: 80 });
			columns.push({ field: 'HomePhone', width: 80 });
			columns.push({ field: 'Extension', width: 80 });
			columns.push({ field: 'Photo', width: 80 });
			columns.push({ field: 'Notes', width: 80 });
			columns.push({ field: 'ReportsTo', width: 80 });
			columns.push({ field: 'PhotoPath', width: 80 });
			return columns;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Northwind_EmployeeTerritoryDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_EmployeeTerritoryForm, $asm, {
		get_territoryID: function() {
			return this.byId(Serenity.StringEditor).call(this, 'TerritoryID');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Northwind_EmployeeTerritoryGrid, $asm, {
		getColumns: function() {
			var columns = ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this);
			columns.push({ field: 'EmployeeID', width: 55, cssClass: 'align-right', name: Q.text('Db.Shared.RecordId') });
			columns.push({ field: 'TerritoryID', width: 200, format: this.itemLink(null, null, null, null, true) });
			return columns;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Northwind_FreightFormatter, $asm, {
		format: function(ctx) {
			return "<span class='freight-symbol'>" + Q.htmlEncode(ctx.value) + '</span>';
		}
	}, null, [Serenity.ISlickFormatter]);
	ss.initEnum($NERP_Northwind_Gender, $asm, { Male: 1, Female: 2 });
	ss.initClass($NERP_Northwind_NoteDialog, $asm, {
		getTemplate: function() {
			return "<form id='~_Form' class='s-Form'><textarea id='~_Text' class='required'></textarea></form>";
		},
		getDialogOptions: function() {
			var opt = ss.makeGenericType(Serenity.TemplatedDialog$1, [Object]).prototype.getDialogOptions.call(this);
			var $t1 = [];
			$t1.push({ text: Q.text('Dialogs.OkButton'), click: ss.mkdel(this, function() {
				if (!this.validateForm()) {
					return;
				}
				if (!ss.staticEquals(this.okClick, null)) {
					this.okClick();
				}
			}) });
			$t1.push({ text: Q.text('Dialogs.CancelButton'), click: ss.mkdel(this, this.dialogClose) });
			opt.buttons = $t1;
			return opt;
		},
		get_text: function() {
			return this.byId$1('Text').val();
		},
		set_text: function(value) {
			this.byId$1('Text').val(value);
		}
	}, Serenity.TemplatedDialog, [Serenity.IDialog]);
	ss.initClass($NERP_Northwind_NotesEditor, $asm, {
		getTemplate: function() {
			return "<div><div id='~_Toolbar'></div><ul id='~_NoteList'></ul></div>";
		},
		$updateContent: function() {
			var noteList = this.byId$1('NoteList');
			noteList.children().remove();
			if (ss.isValue(this.$items)) {
				var index = 0;
				for (var $t1 = 0; $t1 < this.$items.length; $t1++) {
					var item = this.$items[$t1];
					var li = $('<li/>');
					$('<div/>').addClass('note-text').html(ss.coalesce(item.Text, '')).appendTo(li);
					$('<a/>').attr('href', '#').addClass('note-date').text(item.InsertUserDisplayName + ' - ' + Q.formatDate(Q.parseISODateTime(item.InsertDate), 'dd/MM/yyyy HH:mm')).data('index', index).appendTo(li).click(ss.mkdel(this, this.$editClick));
					$('<a/>').attr('href', '#').addClass('note-delete').attr('title', 'delete note').data('index', index).appendTo(li).click(ss.mkdel(this, this.$deleteClick));
					li.appendTo(noteList);
					index++;
				}
			}
		},
		$addClick: function() {
			var dlg = new $NERP_Northwind_NoteDialog();
			dlg.set_dialogTitle('Add Note');
			dlg.okClick = ss.mkdel(this, function() {
				var text = Q.trimToNull(dlg.get_text());
				if (ss.isNullOrUndefined(text)) {
					return;
				}
				this.$items = this.$items || [];
				ss.insert(this.$items, 0, { Text: text, InsertUserDisplayName: $NERP_Authorization.get_userDefinition().DisplayName, InsertDate: Q.formatISODateTimeUTC(new Date()) });
				this.$updateContent();
				dlg.dialogClose();
				this.set_isDirty(true);
				if (!ss.staticEquals(this.get_onChange(), null)) {
					this.get_onChange()();
				}
			});
			dlg.dialogOpen();
		},
		$editClick: function(e) {
			e.preventDefault();
			var index = $(e.target).data('index');
			var old = this.$items[index];
			var dlg = new $NERP_Northwind_NoteDialog();
			dlg.set_dialogTitle('Edit Note');
			dlg.set_text(old.Text);
			dlg.okClick = ss.mkdel(this, function() {
				var text = Q.trimToNull(dlg.get_text());
				if (ss.isNullOrUndefined(text)) {
					return;
				}
				this.$items[index].Text = text;
				this.$updateContent();
				dlg.dialogClose();
				this.set_isDirty(true);
				if (!ss.staticEquals(this.get_onChange(), null)) {
					this.get_onChange()();
				}
			});
			dlg.dialogOpen();
		},
		$deleteClick: function(e) {
			e.preventDefault();
			var index = $(e.target).data('index');
			Q.confirm('Delete this note?', ss.mkdel(this, function() {
				ss.removeAt(this.$items, index);
				this.$updateContent();
				this.set_isDirty(true);
				if (!ss.staticEquals(this.get_onChange(), null)) {
					this.get_onChange()();
				}
			}));
		},
		get_value: function() {
			return this.$items;
		},
		set_value: function(value) {
			this.$items = value || [];
			this.set_isDirty(false);
			this.$updateContent();
		},
		getEditValue: function(property, target) {
			target[property.name] = this.get_value();
		},
		setEditValue: function(source, property) {
			this.set_value(ss.cast(source[property.name], Array));
		},
		get_isDirty: function() {
			return this.$6$IsDirtyField;
		},
		set_isDirty: function(value) {
			this.$6$IsDirtyField = value;
		},
		get_onChange: function() {
			return this.$6$OnChangeField;
		},
		set_onChange: function(value) {
			this.$6$OnChangeField = value;
		}
	}, Serenity.TemplatedWidget, [Serenity.IGetEditValue, Serenity.ISetEditValue]);
	ss.initClass($NERP_Northwind_OrderDetailDialog, $asm, {}, ss.makeGenericType($NERP_Common_GridEditorDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Northwind_OrderDetailForm, $asm, {
		get_productID: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'ProductID');
		},
		get_unitPrice: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'UnitPrice');
		},
		get_quantity: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'Quantity');
		},
		get_discount: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'Discount');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Northwind_OrderDetailsEditor, $asm, {
		validateEntity: function(row, id) {
			row.ProductID = Serenity.IdExtensions.toInt32(row.ProductID);
			var sameProduct = Enumerable.from(this.view.getItems()).firstOrDefault(function(x) {
				return ss.referenceEquals(x.ProductID, row.ProductID);
			}, ss.getDefaultValue(Object));
			if (ss.isValue(sameProduct) && !ss.referenceEquals(this.id(sameProduct), id)) {
				Q.alert('This product is already in order details!');
				return false;
			}
			row.ProductName = Q.getLookup('Northwind.Product').get_itemById()[row.ProductID].ProductName;
			row.LineTotal = ss.coalesce(row.Quantity, 0) * ss.coalesce(row.UnitPrice, 0) - ss.coalesce(row.Discount, 0);
			return true;
		}
	}, ss.makeGenericType($NERP_Common_GridEditorBase$1, [Object]), [Serenity.IDataGrid, Serenity.ISetEditValue, Serenity.IGetEditValue]);
	ss.initClass($NERP_Northwind_OrderForm, $asm, {
		get_customerID: function() {
			return this.byId($NERP_Northwind_CustomerEditor).call(this, 'CustomerID');
		},
		get_orderDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'OrderDate');
		},
		get_requiredDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'RequiredDate');
		},
		get_employeeID: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'EmployeeID');
		},
		get_detailList: function() {
			return this.byId($NERP_Northwind_OrderDetailsEditor).call(this, 'DetailList');
		},
		get_shippedDate: function() {
			return this.byId(Serenity.DateEditor).call(this, 'ShippedDate');
		},
		get_shipVia: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'ShipVia');
		},
		get_freight: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'Freight');
		},
		get_shipName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ShipName');
		},
		get_shipAddress: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ShipAddress');
		},
		get_shipCity: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ShipCity');
		},
		get_shipRegion: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ShipRegion');
		},
		get_shipPostalCode: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ShipPostalCode');
		},
		get_shipCountry: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ShipCountry');
		}
	}, Serenity.PrefixedContext);
	ss.initEnum($NERP_Northwind_OrderShippingState, $asm, { NotShipped: 0, Shipped: 1 });
	ss.initClass($NERP_Northwind_PhoneEditor, $asm, {
		formatValue: function() {
			this.element.val(this.getFormattedValue());
		},
		getFormattedValue: function() {
			var value = this.element.val();
			if (this.get_multiple()) {
				return $NERP_Northwind_PhoneEditor.$formatMulti(value, $NERP_Northwind_PhoneEditor.$formatPhone);
			}
			return $NERP_Northwind_PhoneEditor.$formatPhone(value);
		},
		get_multiple: function() {
			return this.$5$MultipleField;
		},
		set_multiple: function(value) {
			this.$5$MultipleField = value;
		},
		get_value: function() {
			return this.getFormattedValue();
		},
		set_value: function(value) {
			this.element.val(value);
		}
	}, Serenity.StringEditor, [Serenity.IStringValue]);
	ss.initClass($NERP_Northwind_ProductDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_ProductForm, $asm, {
		get_productName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ProductName');
		},
		get_productImage: function() {
			return this.byId(Serenity.ImageUploadEditor).call(this, 'ProductImage');
		},
		get_discontinued: function() {
			return this.byId(Serenity.BooleanEditor).call(this, 'Discontinued');
		},
		get_supplierID: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'SupplierID');
		},
		get_categoryID: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'CategoryID');
		},
		get_quantityPerUnit: function() {
			return this.byId(Serenity.StringEditor).call(this, 'QuantityPerUnit');
		},
		get_unitPrice: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'UnitPrice');
		},
		get_unitsInStock: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'UnitsInStock');
		},
		get_unitsOnOrder: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'UnitsOnOrder');
		},
		get_reorderLevel: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ReorderLevel');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Northwind_ProductGrid, $asm, {
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			var $t1 = Serenity.LookupEditorOptions.$ctor();
			$t1.lookupKey = 'Northwind.Supplier';
			this.addEqualityFilter(Serenity.LookupEditor).call(this, 'SupplierID', null, $t1, null, null, null);
			var $t2 = Serenity.LookupEditorOptions.$ctor();
			$t2.lookupKey = 'Northwind.Category';
			this.addEqualityFilter(Serenity.LookupEditor).call(this, 'CategoryID', null, $t2, null, null, null);
		},
		getButtons: function() {
			var buttons = ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.getButtons.call(this);
			buttons.push($NERP_Common_ExcelExportHelper.createToolButton(this, 'Northwind/Product/ListExcel', ss.mkdel(this, this.onViewSubmit), 'Excel'));
			buttons.push({ title: 'Save Changes', cssClass: 'apply-changes-button', onClick: ss.mkdel(this, function(e) {
				this.$saveClick();
			}) });
			return buttons;
		},
		onViewProcessData: function(response) {
			ss.clearKeys(this.$pendingChanges);
			this.$setSaveButtonState();
			return ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onViewProcessData.call(this, response);
		},
		$inputFormatter: function(ctx) {
			var klass = 'edit';
			var item = ctx.item;
			var pending = this.$pendingChanges[ss.unbox(item.ProductID)];
			if (!!(ss.isValue(pending) && ss.isValue(pending[ctx.column.field]))) {
				klass += ' dirty';
			}
			var value = this.$getEffectiveValue(item, ctx.column.field);
			return "<input type='text' class='" + klass + "'" + " value='" + Q.formatNumber(value, '0.##') + "'" + '/>';
		},
		$getEffectiveValue: function(item, field) {
			var pending = this.$pendingChanges[ss.unbox(item.ProductID)];
			if (ss.isValue(pending)) {
				var $t1 = pending[field];
				if (ss.isNullOrUndefined($t1)) {
					$t1 = item[field];
				}
				return ss.cast($t1, Number);
			}
			return ss.cast(item[field], Number);
		},
		getColumns: function() {
			var columns = ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.getColumns.call(this);
			Enumerable.from(columns).single(function(x) {
				return x.field === 'UnitPrice';
			}).format = ss.mkdel(this, this.$inputFormatter);
			Enumerable.from(columns).single(function(x1) {
				return x1.field === 'UnitsInStock';
			}).format = ss.mkdel(this, this.$inputFormatter);
			Enumerable.from(columns).single(function(x2) {
				return x2.field === 'UnitsOnOrder';
			}).format = ss.mkdel(this, this.$inputFormatter);
			Enumerable.from(columns).single(function(x3) {
				return x3.field === 'ReorderLevel';
			}).format = ss.mkdel(this, this.$inputFormatter);
			return columns;
		},
		$inputsChange: function(e) {
			var cell = this.slickGrid.getCellFromEvent(e);
			var item = this.get_items()[cell.row];
			var field = this.getColumns()[cell.cell].field;
			var input = $(e.target);
			var text = ss.coalesce(Q.trimToNull(input.val()), '0');
			var pending = this.$pendingChanges[ss.unbox(item.ProductID)];
			var oldText = Q.formatNumber(this.$getEffectiveValue(item, field), '0.##');
			var value;
			if (field === 'UnitPrice') {
				value = Q.parseDecimal(text);
				if (ss.isNullOrUndefined(value) || isNaN(ss.unbox(value))) {
					Q.notifyError(Q.text('Validation.Decimal'));
					input.val(oldText);
					input.focus();
					return;
				}
			}
			else {
				var i = {};
				if (!ss.Int32.tryParse(text, i) || i.$ > 32767 || i.$ < 0) {
					Q.notifyError(Q.text('Validation.Integer'));
					input.val(oldText);
					input.focus();
					return;
				}
				value = i.$;
			}
			if (ss.isNullOrUndefined(pending)) {
				this.$pendingChanges[ss.unbox(item.ProductID)] = pending = {};
			}
			pending[field] = value;
			input.val(Q.formatNumber(value, '0.##')).addClass('dirty');
			this.$setSaveButtonState();
		},
		$setSaveButtonState: function() {
			this.toolbar.findButton('apply-changes-button').toggleClass('disabled', ss.getKeyCount(this.$pendingChanges) === 0);
		},
		$saveClick: function() {
			if (ss.getKeyCount(this.$pendingChanges) === 0) {
				return;
			}
			// this calls save service for all modified rows, one by one
			// you could write a batch update service
			var enumerator = new ss.ObjectEnumerator(Q.deepClone(this.$pendingChanges));
			var saveNext = null;
			saveNext = ss.mkdel(this, function() {
				if (!enumerator.moveNext()) {
					this.refresh();
					return;
				}
				var pair = enumerator.current();
				var entity = Q.deepClone(pair.value);
				entity.ProductID = pair.key;
				Q.serviceRequest('Northwind/Product/Update', { EntityId: pair.key, Entity: entity }, ss.mkdel(this, function(response) {
					delete this.$pendingChanges[pair.key];
					saveNext();
				}), null);
			});
			saveNext();
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Northwind_RegionDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_RegionForm, $asm, {
		get_regionID: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'RegionID');
		},
		get_regionDescription: function() {
			return this.byId(Serenity.StringEditor).call(this, 'RegionDescription');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Northwind_RegionGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_ShipperDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_ShipperForm, $asm, {
		get_companyName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CompanyName');
		},
		get_phone: function() {
			return this.byId($NERP_Northwind_PhoneEditor).call(this, 'Phone');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Northwind_ShipperFormatter, $asm, {
		format: function(ctx) {
			return "<span class='shipper-symbol shipper-" + ss.replaceAllString(ss.coalesce(ss.safeCast(ctx.value, String), ''), ' ', '') + "'>" + Q.htmlEncode(ctx.value) + '</span>';
		}
	}, null, [Serenity.ISlickFormatter]);
	ss.initClass($NERP_Northwind_ShipperGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_SupplierDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_SupplierForm, $asm, {
		get_companyName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'CompanyName');
		},
		get_contactName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ContactName');
		},
		get_contactTitle: function() {
			return this.byId(Serenity.StringEditor).call(this, 'ContactTitle');
		},
		get_address: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Address');
		},
		get_city: function() {
			return this.byId(Serenity.StringEditor).call(this, 'City');
		},
		get_region: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Region');
		},
		get_postalCode: function() {
			return this.byId(Serenity.StringEditor).call(this, 'PostalCode');
		},
		get_country: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Country');
		},
		get_phone: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Phone');
		},
		get_fax: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Fax');
		},
		get_homePage: function() {
			return this.byId(Serenity.StringEditor).call(this, 'HomePage');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Northwind_SupplierGrid, $asm, {
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			var $t2 = ss.mkdel(this, function(e) {
				e.appendTo(this.toolbar.get_element()).attr('placeholder', '--- ' + Q.text('Db.Northwind.Supplier.Country') + ' ---');
			});
			var $t1 = Serenity.LookupEditorOptions.$ctor();
			$t1.lookupKey = 'Northwind.SupplierCountry';
			this.$country = Serenity.Widget.create(Serenity.LookupEditor).call(null, $t2, $t1, null);
			Serenity.WX.change(this.$country, ss.mkdel(this, function(e1) {
				this.refresh();
			}));
		},
		onViewSubmit: function() {
			if (!ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onViewSubmit.call(this)) {
				return false;
			}
			this.setEquality('Country', this.$country.get_value());
			return true;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_TerritoryDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog, Serenity.IAsyncInit]);
	ss.initClass($NERP_Northwind_TerritoryForm, $asm, {
		get_territoryID: function() {
			return this.byId(Serenity.StringEditor).call(this, 'TerritoryID');
		},
		get_territoryDescription: function() {
			return this.byId(Serenity.StringEditor).call(this, 'TerritoryDescription');
		},
		get_regionID: function() {
			return this.byId(Serenity.LookupEditor).call(this, 'RegionID');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Northwind_TerritoryGrid, $asm, {
		createToolbarExtensions: function() {
			ss.makeGenericType(Serenity.EntityGrid$2, [Object, Object]).prototype.createToolbarExtensions.call(this);
			var $t2 = ss.mkdel(this, function(e) {
				e.appendTo(this.toolbar.get_element()).attr('placeholder', '--- ' + Q.text('Db.Northwind.Territory.RegionDescription') + ' ---');
			});
			var $t1 = Serenity.LookupEditorOptions.$ctor();
			$t1.lookupKey = 'Northwind.Region';
			this.$region = Serenity.Widget.create(Serenity.LookupEditor).call(null, $t2, $t1, null);
			Serenity.WX.change(this.$region, ss.mkdel(this, function(e1) {
				this.refresh();
			}));
		},
		onViewSubmit: function() {
			if (!ss.makeGenericType(Serenity.DataGrid$2, [Object, Object]).prototype.onViewSubmit.call(this)) {
				return false;
			}
			this.setEquality('RegionID', Serenity.IdExtensions.convertToId(this.$region.get_value()));
			return true;
		}
	}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid, Serenity.IAsyncInit]);
	ss.initClass($NERP_Purchase_SupplierDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Purchase_SupplierForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_userTypeId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'UserTypeId');
		},
		get_userGroupId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'UserGroupId');
		},
		get_firstName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'FirstName');
		},
		get_middleName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'MiddleName');
		},
		get_lastName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'LastName');
		},
		get_fullName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'FullName');
		},
		get_imageId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ImageId');
		},
		get_address1: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Address1');
		},
		get_address2: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Address2');
		},
		get_mobile: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Mobile');
		},
		get_email: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Email');
		},
		get_dateOfBirth: function() {
			return this.byId(Serenity.DateEditor).call(this, 'DateOfBirth');
		},
		get_loginName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'LoginName');
		},
		get_password: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Password');
		},
		get_isTaxable: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'IsTaxable');
		},
		get_commissionRate: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'CommissionRate');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Purchase_SupplierGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($NERP_Sales_CustomerDialog, $asm, {}, ss.makeGenericType(Serenity.EntityDialog$1, [Object]), [Serenity.IDialog, Serenity.IEditDialog]);
	ss.initClass($NERP_Sales_CustomerForm, $asm, {
		get_code: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Code');
		},
		get_name: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Name');
		},
		get_description: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Description');
		},
		get_userTypeId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'UserTypeId');
		},
		get_userGroupId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'UserGroupId');
		},
		get_firstName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'FirstName');
		},
		get_middleName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'MiddleName');
		},
		get_lastName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'LastName');
		},
		get_fullName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'FullName');
		},
		get_imageId: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'ImageId');
		},
		get_address1: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Address1');
		},
		get_address2: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Address2');
		},
		get_mobile: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Mobile');
		},
		get_email: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Email');
		},
		get_dateOfBirth: function() {
			return this.byId(Serenity.DateEditor).call(this, 'DateOfBirth');
		},
		get_loginName: function() {
			return this.byId(Serenity.StringEditor).call(this, 'LoginName');
		},
		get_password: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Password');
		},
		get_isTaxable: function() {
			return this.byId(Serenity.IntegerEditor).call(this, 'IsTaxable');
		},
		get_commissionRate: function() {
			return this.byId(Serenity.DecimalEditor).call(this, 'CommissionRate');
		},
		get_note: function() {
			return this.byId(Serenity.StringEditor).call(this, 'Note');
		}
	}, Serenity.PrefixedContext);
	ss.initClass($NERP_Sales_CustomerGrid, $asm, {}, ss.makeGenericType(Serenity.EntityGrid$1, [Object]), [Serenity.IDataGrid]);
	ss.initClass($Serenity_HtmlBasicContentEditor, $asm, {
		getConfig: function() {
			var config = Serenity.HtmlContentEditor.prototype.getConfig.call(this);
			config.removeButtons += ',Cut,Copy,Paste,BulletedList,NumberedList,Indent,Outdent,SpecialChar,Subscript,Superscript,Styles,PasteText,PasteFromWord,Strike,Link,Unlink,CreatePlaceholder,Image,Table,HorizontalRule,Source,Maximize,Format,Font,FontSize,Anchor,Blockquote,CreatePlaceholder,BGColor,JustifyLeft,JustifyCenter,JustifyRight,JustifyBlock,Superscript,RemoveFormat';
			config.removePlugins += ',elementspath';
			return config;
		}
	}, Serenity.HtmlContentEditor, [Serenity.IStringValue]);
	ss.setMetadata($NERP_Accounting_COADialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Accounting.COA'), new Serenity.LocalTextPrefixAttribute('Accounting.COA'), new Serenity.ServiceAttribute('Accounting/COA')] });
	ss.setMetadata($NERP_Accounting_COAGrid, { attr: [new Serenity.ColumnsKeyAttribute('Accounting.COA'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Accounting_COADialog), new Serenity.LocalTextPrefixAttribute('Accounting.COA'), new Serenity.ServiceAttribute('Accounting/COA')] });
	ss.setMetadata($NERP_Administration_LanguageDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('LanguageName'), new Serenity.FormKeyAttribute('Administration.Language'), new Serenity.LocalTextPrefixAttribute('Administration.Language'), new Serenity.ServiceAttribute('Administration/Language')] });
	ss.setMetadata($NERP_Administration_LanguageGrid, { attr: [new Serenity.ColumnsKeyAttribute('Administration.Language'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('LanguageName'), new Serenity.DialogTypeAttribute($NERP_Administration_LanguageDialog), new Serenity.LocalTextPrefixAttribute('Administration.Language'), new Serenity.ServiceAttribute('Administration/Language')] });
	ss.setMetadata($NERP_Administration_PermissionCheckEditor, { attr: [new Serenity.EditorAttribute(), new Serenity.IdPropertyAttribute('Key')] });
	ss.setMetadata($NERP_Administration_PermissionModuleEditor, { attr: [new Serenity.EditorAttribute()] });
	ss.setMetadata($NERP_Administration_RoleCheckEditor, { attr: [new Serenity.EditorAttribute()] });
	ss.setMetadata($NERP_Administration_RoleDialog, { attr: [new Serenity.IdPropertyAttribute('RoleId'), new Serenity.NamePropertyAttribute('RoleName'), new Serenity.FormKeyAttribute('Administration.Role'), new Serenity.LocalTextPrefixAttribute('Administration.Role'), new Serenity.ServiceAttribute('Administration/Role')] });
	ss.setMetadata($NERP_Administration_RoleGrid, { attr: [new Serenity.ColumnsKeyAttribute('Administration.Role'), new Serenity.IdPropertyAttribute('RoleId'), new Serenity.NamePropertyAttribute('RoleName'), new Serenity.DialogTypeAttribute($NERP_Administration_RoleDialog), new Serenity.LocalTextPrefixAttribute('Administration.Role'), new Serenity.ServiceAttribute('Administration/Role')] });
	ss.setMetadata($NERP_Administration_TranslationGrid, { attr: [new Serenity.ColumnsKeyAttribute('Administration.Translation'), new Serenity.IdPropertyAttribute('Key'), new Serenity.LocalTextPrefixAttribute('Administration.Translation'), new Serenity.ServiceAttribute('Administration/Translation')] });
	ss.setMetadata($NERP_Administration_UserDialog, { attr: [new Serenity.IdPropertyAttribute('UserId'), new Serenity.NamePropertyAttribute('Username'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Administration.User'), new Serenity.LocalTextPrefixAttribute('Administration.User'), new Serenity.ServiceAttribute('Administration/User')] });
	ss.setMetadata($NERP_Administration_UserGrid, { attr: [new Serenity.IdPropertyAttribute('UserId'), new Serenity.NamePropertyAttribute('Username'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Administration_UserDialog), new Serenity.LocalTextPrefixAttribute('Administration.User'), new Serenity.ServiceAttribute('Administration/User')] });
	ss.setMetadata($NERP_Common_GridEditorBase$1, { attr: [new Serenity.ElementAttribute('<div/>'), new Serenity.EditorAttribute(), new Serenity.IdPropertyAttribute('__id')] });
	ss.setMetadata($NERP_Common_GridEditorDialog$1, { attr: [new Serenity.IdPropertyAttribute('__id')] });
	ss.setMetadata($NERP_Configuration_BrandDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.Brand'), new Serenity.LocalTextPrefixAttribute('Configuration.Brand'), new Serenity.ServiceAttribute('Configuration/Brand')] });
	ss.setMetadata($NERP_Configuration_BrandGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.Brand'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_BrandDialog), new Serenity.LocalTextPrefixAttribute('Configuration.Brand'), new Serenity.ServiceAttribute('Configuration/Brand')] });
	ss.setMetadata($NERP_Configuration_ColorDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.Color'), new Serenity.LocalTextPrefixAttribute('Configuration.Color'), new Serenity.ServiceAttribute('Configuration/Color')] });
	ss.setMetadata($NERP_Configuration_ColorGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.Color'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_ColorDialog), new Serenity.LocalTextPrefixAttribute('Configuration.Color'), new Serenity.ServiceAttribute('Configuration/Color')] });
	ss.setMetadata($NERP_Configuration_CurrencyDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.Currency'), new Serenity.LocalTextPrefixAttribute('Configuration.Currency'), new Serenity.ServiceAttribute('Configuration/Currency')] });
	ss.setMetadata($NERP_Configuration_CurrencyGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.Currency'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_CurrencyDialog), new Serenity.LocalTextPrefixAttribute('Configuration.Currency'), new Serenity.ServiceAttribute('Configuration/Currency')] });
	ss.setMetadata($NERP_Configuration_GenericItemDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.GenericItem'), new Serenity.LocalTextPrefixAttribute('Configuration.GenericItem'), new Serenity.ServiceAttribute('Configuration/GenericItem')] });
	ss.setMetadata($NERP_Configuration_GenericItemGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.GenericItem'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_GenericItemDialog), new Serenity.LocalTextPrefixAttribute('Configuration.GenericItem'), new Serenity.ServiceAttribute('Configuration/GenericItem')] });
	ss.setMetadata($NERP_Configuration_ItemCategoryDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.ItemCategory'), new Serenity.LocalTextPrefixAttribute('Configuration.ItemCategory'), new Serenity.ServiceAttribute('Configuration/ItemCategory')] });
	ss.setMetadata($NERP_Configuration_ItemCategoryGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.ItemCategory'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_ItemCategoryDialog), new Serenity.LocalTextPrefixAttribute('Configuration.ItemCategory'), new Serenity.ServiceAttribute('Configuration/ItemCategory')] });
	ss.setMetadata($NERP_Configuration_ItemDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.Item'), new Serenity.LocalTextPrefixAttribute('Configuration.Item'), new Serenity.ServiceAttribute('Configuration/Item'), new Serenity.FlexifyAttribute(), new Serenity.MaximizableAttribute()] });
	ss.setMetadata($NERP_Configuration_ItemGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.Item'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_ItemDialog), new Serenity.LocalTextPrefixAttribute('Configuration.Item'), new Serenity.ServiceAttribute('Configuration/Item')] });
	ss.setMetadata($NERP_Configuration_ItemTaxDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.ItemTax'), new Serenity.LocalTextPrefixAttribute('Configuration.ItemTax'), new Serenity.ServiceAttribute('Configuration/ItemTax')] });
	ss.setMetadata($NERP_Configuration_ItemTaxGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.ItemTax'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_ItemTaxDialog), new Serenity.LocalTextPrefixAttribute('Configuration.ItemTax'), new Serenity.ServiceAttribute('Configuration/ItemTax')] });
	ss.setMetadata($NERP_Configuration_ModelDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.Model'), new Serenity.LocalTextPrefixAttribute('Configuration.Model'), new Serenity.ServiceAttribute('Configuration/Model')] });
	ss.setMetadata($NERP_Configuration_ModelGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.Model'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_ModelDialog), new Serenity.LocalTextPrefixAttribute('Configuration.Model'), new Serenity.ServiceAttribute('Configuration/Model')] });
	ss.setMetadata($NERP_Configuration_OrganogramDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.Organogram'), new Serenity.LocalTextPrefixAttribute('Configuration.Organogram'), new Serenity.ServiceAttribute('Configuration/Organogram')] });
	ss.setMetadata($NERP_Configuration_OrganogramGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.Organogram'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_OrganogramDialog), new Serenity.LocalTextPrefixAttribute('Configuration.Organogram'), new Serenity.ServiceAttribute('Configuration/Organogram')] });
	ss.setMetadata($NERP_Configuration_PaymentMethodDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.PaymentMethod'), new Serenity.LocalTextPrefixAttribute('Configuration.PaymentMethod'), new Serenity.ServiceAttribute('Configuration/PaymentMethod')] });
	ss.setMetadata($NERP_Configuration_PaymentMethodGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.PaymentMethod'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_PaymentMethodDialog), new Serenity.LocalTextPrefixAttribute('Configuration.PaymentMethod'), new Serenity.ServiceAttribute('Configuration/PaymentMethod')] });
	ss.setMetadata($NERP_Configuration_ProjectDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.Project'), new Serenity.LocalTextPrefixAttribute('Configuration.Project'), new Serenity.ServiceAttribute('Configuration/Project')] });
	ss.setMetadata($NERP_Configuration_ProjectGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.Project'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_ProjectDialog), new Serenity.LocalTextPrefixAttribute('Configuration.Project'), new Serenity.ServiceAttribute('Configuration/Project')] });
	ss.setMetadata($NERP_Configuration_SizeDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.Size'), new Serenity.LocalTextPrefixAttribute('Configuration.Size'), new Serenity.ServiceAttribute('Configuration/Size')] });
	ss.setMetadata($NERP_Configuration_SizeGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.Size'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_SizeDialog), new Serenity.LocalTextPrefixAttribute('Configuration.Size'), new Serenity.ServiceAttribute('Configuration/Size')] });
	ss.setMetadata($NERP_Configuration_SpecificationDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.Specification'), new Serenity.LocalTextPrefixAttribute('Configuration.Specification'), new Serenity.ServiceAttribute('Configuration/Specification')] });
	ss.setMetadata($NERP_Configuration_SpecificationGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.Specification'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_SpecificationDialog), new Serenity.LocalTextPrefixAttribute('Configuration.Specification'), new Serenity.ServiceAttribute('Configuration/Specification')] });
	ss.setMetadata($NERP_Configuration_StyleDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.Style'), new Serenity.LocalTextPrefixAttribute('Configuration.Style'), new Serenity.ServiceAttribute('Configuration/Style')] });
	ss.setMetadata($NERP_Configuration_StyleGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.Style'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_StyleDialog), new Serenity.LocalTextPrefixAttribute('Configuration.Style'), new Serenity.ServiceAttribute('Configuration/Style')] });
	ss.setMetadata($NERP_Configuration_TaxDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.Tax'), new Serenity.LocalTextPrefixAttribute('Configuration.Tax'), new Serenity.ServiceAttribute('Configuration/Tax')] });
	ss.setMetadata($NERP_Configuration_TaxGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.Tax'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_TaxDialog), new Serenity.LocalTextPrefixAttribute('Configuration.Tax'), new Serenity.ServiceAttribute('Configuration/Tax')] });
	ss.setMetadata($NERP_Configuration_UomDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Configuration.Uom'), new Serenity.LocalTextPrefixAttribute('Configuration.Uom'), new Serenity.ServiceAttribute('Configuration/Uom')] });
	ss.setMetadata($NERP_Configuration_UomGrid, { attr: [new Serenity.ColumnsKeyAttribute('Configuration.Uom'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Configuration_UomDialog), new Serenity.LocalTextPrefixAttribute('Configuration.Uom'), new Serenity.ServiceAttribute('Configuration/Uom')] });
	ss.setMetadata($NERP_HR_EmployeeDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('HR.Employee'), new Serenity.LocalTextPrefixAttribute('HR.Employee'), new Serenity.ServiceAttribute('HR/Employee')] });
	ss.setMetadata($NERP_HR_EmployeeGrid, { attr: [new Serenity.ColumnsKeyAttribute('HR.Employee'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_HR_EmployeeDialog), new Serenity.LocalTextPrefixAttribute('HR.Employee'), new Serenity.ServiceAttribute('HR/Employee')] });
	ss.setMetadata($NERP_Inventory_StockDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.FormKeyAttribute('Inventory.Stock'), new Serenity.LocalTextPrefixAttribute('Inventory.Stock'), new Serenity.ServiceAttribute('Inventory/Stock')] });
	ss.setMetadata($NERP_Inventory_StockGrid, { attr: [new Serenity.ColumnsKeyAttribute('Inventory.Stock'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.DialogTypeAttribute($NERP_Inventory_StockDialog), new Serenity.LocalTextPrefixAttribute('Inventory.Stock'), new Serenity.ServiceAttribute('Inventory/Stock')] });
	ss.setMetadata($NERP_ItemTransaction_TransDetailDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('ItemTransaction.TransDetail'), new Serenity.LocalTextPrefixAttribute('ItemTransaction.TransDetail'), new Serenity.ServiceAttribute('ItemTransaction/TransDetail')] });
	ss.setMetadata($NERP_ItemTransaction_TransDetailEditDialog, { attr: [new Serenity.NamePropertyAttribute('ItemName'), new Serenity.FormKeyAttribute('ItemTransaction.TransDetail'), new Serenity.LocalTextPrefixAttribute('ItemTransaction.TransDetail')] });
	ss.setMetadata($NERP_ItemTransaction_TransDetailEditor, { attr: [new Serenity.ColumnsKeyAttribute('ItemTransaction.TransDetail'), new Serenity.LocalTextPrefixAttribute('ItemTransaction.TransDetail'), new Serenity.DialogTypeAttribute($NERP_ItemTransaction_TransDetailEditDialog)] });
	ss.setMetadata($NERP_ItemTransaction_TransDetailGrid, { attr: [new Serenity.ColumnsKeyAttribute('ItemTransaction.TransDetail'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_ItemTransaction_TransDetailDialog), new Serenity.LocalTextPrefixAttribute('ItemTransaction.TransDetail'), new Serenity.ServiceAttribute('ItemTransaction/TransDetail')] });
	ss.setMetadata($NERP_ItemTransaction_TransDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('ItemTransaction.Trans'), new Serenity.LocalTextPrefixAttribute('ItemTransaction.Trans'), new Serenity.ServiceAttribute('ItemTransaction/Trans'), new Serenity.FlexifyAttribute(), new Serenity.MaximizableAttribute()] });
	ss.setMetadata($NERP_ItemTransaction_TransGrid, { attr: [new Serenity.ColumnsKeyAttribute('ItemTransaction.Trans'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_ItemTransaction_TransDialog), new Serenity.LocalTextPrefixAttribute('ItemTransaction.Trans'), new Serenity.ServiceAttribute('ItemTransaction/Trans')] });
	ss.setMetadata($NERP_ItemTransaction_TransPaymentDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('ItemTransaction.TransPayment'), new Serenity.LocalTextPrefixAttribute('ItemTransaction.TransPayment'), new Serenity.ServiceAttribute('ItemTransaction/TransPayment')] });
	ss.setMetadata($NERP_ItemTransaction_TransPaymentGrid, { attr: [new Serenity.ColumnsKeyAttribute('ItemTransaction.TransPayment'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_ItemTransaction_TransPaymentDialog), new Serenity.LocalTextPrefixAttribute('ItemTransaction.TransPayment'), new Serenity.ServiceAttribute('ItemTransaction/TransPayment')] });
	ss.setMetadata($NERP_ItemTransaction_TransTaxDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('ItemTransaction.TransTax'), new Serenity.LocalTextPrefixAttribute('ItemTransaction.TransTax'), new Serenity.ServiceAttribute('ItemTransaction/TransTax')] });
	ss.setMetadata($NERP_ItemTransaction_TransTaxGrid, { attr: [new Serenity.ColumnsKeyAttribute('ItemTransaction.TransTax'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_ItemTransaction_TransTaxDialog), new Serenity.LocalTextPrefixAttribute('ItemTransaction.TransTax'), new Serenity.ServiceAttribute('ItemTransaction/TransTax')] });
	ss.setMetadata($NERP_Membership_ChangePasswordPanel, { attr: [new Serenity.PanelAttribute(), new Serenity.FormKeyAttribute('Membership.ChangePassword')] });
	ss.setMetadata($NERP_Membership_ForgotPasswordPanel, { attr: [new Serenity.PanelAttribute(), new Serenity.FormKeyAttribute('Membership.ForgotPassword')] });
	ss.setMetadata($NERP_Membership_LoginPanel, { attr: [new Serenity.FormKeyAttribute('Membership.Login')] });
	ss.setMetadata($NERP_Membership_ResetPasswordPanel, { attr: [new Serenity.PanelAttribute(), new Serenity.FormKeyAttribute('Membership.ResetPassword')] });
	ss.setMetadata($NERP_Membership_SignUpPanel, { attr: [new Serenity.PanelAttribute(), new Serenity.FormKeyAttribute('Membership.SignUp')] });
	ss.setMetadata($NERP_Northwind_CategoryDialog, { attr: [new Serenity.IdPropertyAttribute('CategoryID'), new Serenity.NamePropertyAttribute('CategoryName'), new Serenity.FormKeyAttribute('Northwind.Category'), new Serenity.LocalTextPrefixAttribute('Northwind.Category'), new Serenity.ServiceAttribute('Northwind/Category')] });
	ss.setMetadata($NERP_Northwind_CategoryGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Category'), new Serenity.IdPropertyAttribute('CategoryID'), new Serenity.NamePropertyAttribute('CategoryName'), new Serenity.DialogTypeAttribute($NERP_Northwind_CategoryDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Category'), new Serenity.ServiceAttribute('Northwind/Category')] });
	ss.setMetadata($NERP_Northwind_CustomerCustomerDemoDialog, { attr: [new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('CustomerID'), new Serenity.FormKeyAttribute('Northwind.CustomerCustomerDemo'), new Serenity.LocalTextPrefixAttribute('Northwind.CustomerCustomerDemo'), new Serenity.ServiceAttribute('Northwind/CustomerCustomerDemo')] });
	ss.setMetadata($NERP_Northwind_CustomerCustomerDemoGrid, { attr: [new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('CustomerID'), new Serenity.DialogTypeAttribute($NERP_Northwind_CustomerCustomerDemoDialog), new Serenity.LocalTextPrefixAttribute('Northwind.CustomerCustomerDemo'), new Serenity.ServiceAttribute('Northwind/CustomerCustomerDemo')] });
	ss.setMetadata($NERP_Northwind_CustomerDemographicDialog, { attr: [new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('CustomerTypeID'), new Serenity.FormKeyAttribute('Northwind.CustomerDemographic'), new Serenity.LocalTextPrefixAttribute('Northwind.CustomerDemographic'), new Serenity.ServiceAttribute('Northwind/CustomerDemographic')] });
	ss.setMetadata($NERP_Northwind_CustomerDemographicGrid, { attr: [new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('CustomerTypeID'), new Serenity.DialogTypeAttribute($NERP_Northwind_CustomerDemographicDialog), new Serenity.LocalTextPrefixAttribute('Northwind.CustomerDemographic'), new Serenity.ServiceAttribute('Northwind/CustomerDemographic')] });
	ss.setMetadata($NERP_Northwind_CustomerDialog, { attr: [new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('CustomerID'), new Serenity.FlexifyAttribute(), new Serenity.MaximizableAttribute(), new Serenity.FormKeyAttribute('Northwind.Customer'), new Serenity.LocalTextPrefixAttribute('Northwind.Customer'), new Serenity.ServiceAttribute('Northwind/Customer')] });
	ss.setMetadata($NERP_Northwind_CustomerGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Customer'), new Serenity.FilterableAttribute(), new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('CustomerID'), new Serenity.DialogTypeAttribute($NERP_Northwind_CustomerDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Customer'), new Serenity.ServiceAttribute('Northwind/Customer')] });
	ss.setMetadata($NERP_Northwind_CustomerOrdersGrid, { attr: [new Serenity.DialogTypeAttribute($NERP_Northwind_CustomerOrderDialog)] });
	ss.setMetadata($NERP_Northwind_EmployeeDialog, { attr: [new Serenity.IdPropertyAttribute('EmployeeID'), new Serenity.NamePropertyAttribute('LastName'), new Serenity.FormKeyAttribute('Northwind.Employee'), new Serenity.LocalTextPrefixAttribute('Northwind.Employee'), new Serenity.ServiceAttribute('Northwind/Employee')] });
	ss.setMetadata($NERP_Northwind_EmployeeFormatter, { members: [{ attr: [new Serenity.ComponentModel.OptionAttribute()], name: 'GenderProperty', type: 16, returnType: String, getter: { name: 'get_GenderProperty', type: 8, sname: 'get_genderProperty', returnType: String, params: [] }, setter: { name: 'set_GenderProperty', type: 8, sname: 'set_genderProperty', returnType: Object, params: [String] } }] });
	ss.setMetadata($NERP_Northwind_EmployeeGrid, { attr: [new Serenity.IdPropertyAttribute('EmployeeID'), new Serenity.NamePropertyAttribute('LastName'), new Serenity.DialogTypeAttribute($NERP_Northwind_EmployeeDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Employee'), new Serenity.ServiceAttribute('Northwind/Employee')] });
	ss.setMetadata($NERP_Northwind_EmployeeTerritoryDialog, { attr: [new Serenity.IdPropertyAttribute('EmployeeID'), new Serenity.NamePropertyAttribute('TerritoryID'), new Serenity.FormKeyAttribute('Northwind.EmployeeTerritory'), new Serenity.LocalTextPrefixAttribute('Northwind.EmployeeTerritory'), new Serenity.ServiceAttribute('Northwind/EmployeeTerritory')] });
	ss.setMetadata($NERP_Northwind_EmployeeTerritoryGrid, { attr: [new Serenity.IdPropertyAttribute('EmployeeID'), new Serenity.NamePropertyAttribute('TerritoryID'), new Serenity.DialogTypeAttribute($NERP_Northwind_EmployeeTerritoryDialog), new Serenity.LocalTextPrefixAttribute('Northwind.EmployeeTerritory'), new Serenity.ServiceAttribute('Northwind/EmployeeTerritory')] });
	ss.setMetadata($NERP_Northwind_Gender, { attr: [new Serenity.EnumKeyAttribute('NERP.Northwind.Entities.Gender')] });
	ss.setMetadata($NERP_Northwind_NotesEditor, { attr: [new Serenity.EditorAttribute(), new Serenity.ElementAttribute('<div/>')] });
	ss.setMetadata($NERP_Northwind_OrderDetailDialog, { attr: [new Serenity.FormKeyAttribute('Northwind.OrderDetail'), new Serenity.LocalTextPrefixAttribute('Northwind.OrderDetail')] });
	ss.setMetadata($NERP_Northwind_OrderDetailsEditor, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.OrderDetail'), new Serenity.DialogTypeAttribute($NERP_Northwind_OrderDetailDialog), new Serenity.LocalTextPrefixAttribute('Northwind.OrderDetail')] });
	ss.setMetadata($NERP_Northwind_OrderDialog, { attr: [new Serenity.IdPropertyAttribute('OrderID'), new Serenity.NamePropertyAttribute('OrderID'), new Serenity.FlexifyAttribute(), new Serenity.MaximizableAttribute(), new Serenity.FormKeyAttribute('Northwind.Order'), new Serenity.LocalTextPrefixAttribute('Northwind.Order'), new Serenity.ServiceAttribute('Northwind/Order')] });
	ss.setMetadata($NERP_Northwind_OrderGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Order'), new Serenity.IdPropertyAttribute('OrderID'), new Serenity.DialogTypeAttribute($NERP_Northwind_OrderDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Order'), new Serenity.ServiceAttribute('Northwind/Order')] });
	ss.setMetadata($NERP_Northwind_OrderShippingState, { attr: [new Serenity.EnumKeyAttribute('Northwind.OrderShippingState')] });
	ss.setMetadata($NERP_Northwind_PhoneEditor, { attr: [new Serenity.EditorAttribute()], members: [{ attr: [new Serenity.ComponentModel.OptionAttribute()], name: 'Multiple', type: 16, returnType: Boolean, getter: { name: 'get_Multiple', type: 8, sname: 'get_multiple', returnType: Boolean, params: [] }, setter: { name: 'set_Multiple', type: 8, sname: 'set_multiple', returnType: Object, params: [Boolean] } }] });
	ss.setMetadata($NERP_Northwind_ProductDialog, { attr: [new Serenity.IdPropertyAttribute('ProductID'), new Serenity.NamePropertyAttribute('ProductName'), new Serenity.FormKeyAttribute('Northwind.Product'), new Serenity.LocalTextPrefixAttribute('Northwind.Product'), new Serenity.ServiceAttribute('Northwind/Product')] });
	ss.setMetadata($NERP_Northwind_ProductGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Product'), new Serenity.FilterableAttribute(), new Serenity.IdPropertyAttribute('ProductID'), new Serenity.NamePropertyAttribute('ProductName'), new Serenity.DialogTypeAttribute($NERP_Northwind_ProductDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Product'), new Serenity.ServiceAttribute('Northwind/Product')] });
	ss.setMetadata($NERP_Northwind_RegionDialog, { attr: [new Serenity.IdPropertyAttribute('RegionID'), new Serenity.NamePropertyAttribute('RegionDescription'), new Serenity.FormKeyAttribute('Northwind.Region'), new Serenity.LocalTextPrefixAttribute('Northwind.Region'), new Serenity.ServiceAttribute('Northwind/Region')] });
	ss.setMetadata($NERP_Northwind_RegionGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Region'), new Serenity.IdPropertyAttribute('RegionID'), new Serenity.NamePropertyAttribute('RegionDescription'), new Serenity.DialogTypeAttribute($NERP_Northwind_RegionDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Region'), new Serenity.ServiceAttribute('Northwind/Region')] });
	ss.setMetadata($NERP_Northwind_ShipperDialog, { attr: [new Serenity.IdPropertyAttribute('ShipperID'), new Serenity.NamePropertyAttribute('CompanyName'), new Serenity.FormKeyAttribute('Northwind.Shipper'), new Serenity.LocalTextPrefixAttribute('Northwind.Shipper'), new Serenity.ServiceAttribute('Northwind/Shipper')] });
	ss.setMetadata($NERP_Northwind_ShipperGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Shipper'), new Serenity.IdPropertyAttribute('ShipperID'), new Serenity.NamePropertyAttribute('CompanyName'), new Serenity.DialogTypeAttribute($NERP_Northwind_ShipperDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Shipper'), new Serenity.ServiceAttribute('Northwind/Shipper')] });
	ss.setMetadata($NERP_Northwind_SupplierDialog, { attr: [new Serenity.IdPropertyAttribute('SupplierID'), new Serenity.NamePropertyAttribute('CompanyName'), new Serenity.FormKeyAttribute('Northwind.Supplier'), new Serenity.LocalTextPrefixAttribute('Northwind.Supplier'), new Serenity.ServiceAttribute('Northwind/Supplier')] });
	ss.setMetadata($NERP_Northwind_SupplierGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Supplier'), new Serenity.FilterableAttribute(), new Serenity.IdPropertyAttribute('SupplierID'), new Serenity.NamePropertyAttribute('CompanyName'), new Serenity.DialogTypeAttribute($NERP_Northwind_SupplierDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Supplier'), new Serenity.ServiceAttribute('Northwind/Supplier')] });
	ss.setMetadata($NERP_Northwind_TerritoryDialog, { attr: [new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('TerritoryID'), new Serenity.FormKeyAttribute('Northwind.Territory'), new Serenity.LocalTextPrefixAttribute('Northwind.Territory'), new Serenity.ServiceAttribute('Northwind/Territory')] });
	ss.setMetadata($NERP_Northwind_TerritoryGrid, { attr: [new Serenity.ColumnsKeyAttribute('Northwind.Territory'), new Serenity.IdPropertyAttribute('ID'), new Serenity.NamePropertyAttribute('TerritoryID'), new Serenity.DialogTypeAttribute($NERP_Northwind_TerritoryDialog), new Serenity.LocalTextPrefixAttribute('Northwind.Territory'), new Serenity.ServiceAttribute('Northwind/Territory')] });
	ss.setMetadata($NERP_Purchase_SupplierDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Purchase.Supplier'), new Serenity.LocalTextPrefixAttribute('Purchase.Supplier'), new Serenity.ServiceAttribute('Purchase/Supplier')] });
	ss.setMetadata($NERP_Purchase_SupplierGrid, { attr: [new Serenity.ColumnsKeyAttribute('Purchase.Supplier'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Purchase_SupplierDialog), new Serenity.LocalTextPrefixAttribute('Purchase.Supplier'), new Serenity.ServiceAttribute('Purchase/Supplier')] });
	ss.setMetadata($NERP_Sales_CustomerDialog, { attr: [new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.FormKeyAttribute('Sales.Customer'), new Serenity.LocalTextPrefixAttribute('Sales.Customer'), new Serenity.ServiceAttribute('Sales/Customer')] });
	ss.setMetadata($NERP_Sales_CustomerGrid, { attr: [new Serenity.ColumnsKeyAttribute('Sales.Customer'), new Serenity.IdPropertyAttribute('Id'), new Serenity.NamePropertyAttribute('Name'), new Serenity.IsActivePropertyAttribute('IsActive'), new Serenity.DialogTypeAttribute($NERP_Sales_CustomerDialog), new Serenity.LocalTextPrefixAttribute('Sales.Customer'), new Serenity.ServiceAttribute('Sales/Customer')] });
	ss.setMetadata($Serenity_HtmlBasicContentEditor, { attr: [new Serenity.EditorAttribute(), new System.ComponentModel.DisplayNameAttribute('Html Content (Basic Set)'), new Serenity.OptionsTypeAttribute(Serenity.HtmlContentEditorOptions), new Serenity.ElementAttribute('<textarea />')] });
	(function() {
		Q$Config.rootNamespaces.push('NERP');
	})();
})();
